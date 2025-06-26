using OOD_Hospital_Project.Entrants;

namespace OOD_Hospital_Project.AdapterPattern
{
    public abstract class SystemConnector
    {
        public abstract void SendData(List<IEntrants> entrants);
        public abstract List<IEntrants> GetData();

    }

}


