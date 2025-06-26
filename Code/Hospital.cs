using System;
using System.Text;

using OOD_Hospital_Project.AdapterPattern;
using OOD_Hospital_Project.BuilderPattern;
using OOD_Hospital_Project.Entrants;

namespace OOD_Hospital_Project.SingletonPattern
{
    public partial class Hospital
    {
        private static Hospital Instance;
        public string HospitalName { get; set; }
        public string HospitalLocation { get; set; }
        public string HospitalPhoneNumber { get; set; }
        public List<IEntrants> PatientsRecords { get; set; } = new List<IEntrants>();
        List<IEntrants> Entrants { get; set; } = new List<IEntrants> { };


        private Hospital(string hospitalName, string hospitalLocation, string hospitalNumber)
        {

            HospitalName = hospitalName;
            HospitalLocation = hospitalLocation;
            HospitalPhoneNumber = hospitalNumber;
        }

        public static Hospital GetInstance()
        {
            if (Instance == null)
            {
                Instance = new Hospital("PCT Medical Center", "Zouk Mosbeh", "+961 9 111222");
            }

            return Instance;
        }

        public void AddToList(IEntrants e)
        {
            Entrants.Add(e);
        }

        public void Construct(HospitalRoomBuilder RoomBuilder)
        {
            RoomBuilder.BuildBed();
            RoomBuilder.BuildArea();
            RoomBuilder.BuildView();
            RoomBuilder.BuildBathroom();
        }

        public void ExportData(SystemConnector Connector)
        {
            Connector.SendData(Entrants);
        }

        public string DisplayPatientRecords(SystemConnector Connector)
        {
            List<IEntrants> temp = Connector.GetData();
            StringBuilder recordBuilder = new StringBuilder();

            foreach (IEntrants entrant in temp)
            {
                string patientId = entrant is Patient patient ? patient.PatientId.ToString() : "N/A";
                string entrantType = entrant switch
                {
                    IVisitor => "Visitor",
                    InPatient => "InPatient",
                    OutPatient => "OutPatient",
                    _ => "Unknown"
                };

                recordBuilder.Append($"Entrant Number: {patientId}\n" +
                                     $"{entrant.DisplayInfo()}\n");
            }

            return recordBuilder.ToString();
            
        }
    }
}
