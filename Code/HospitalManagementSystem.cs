using OOD_Hospital_Project.Entrants;

namespace OOD_Hospital_Project.AdapterPattern
{
    public class HospitalManagementSystem
    {
        public List<IEntrants> PatientRecords { get; set; }
        public void SaveData(List<IEntrants> entrants)
        {
            PatientRecords = entrants;
        }

        public List<IEntrants> GetData()
        {
            return PatientRecords;
        }
    }

    
}


