using OOD_Hospital_Project.Entrants;


namespace OOD_Hospital_Project.AdapterPattern
{
    public class HospitalManagementSystemConnector : SystemConnector
    {
        private HospitalManagementSystem HMS = new HospitalManagementSystem();
        public override void SendData(List<IEntrants> entrants)
        {

            HMS.SaveData(entrants);
        }

        public override List<IEntrants> GetData()
        {
            return HMS.GetData();
        }
    }

}


