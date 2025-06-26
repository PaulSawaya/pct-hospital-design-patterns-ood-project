namespace OOD_Hospital_Project.BuilderPattern
{
    public abstract class HospitalRoomBuilder
    {
        public HospitalRoom Room { get; set; }
        public abstract void BuildArea();
        public abstract void BuildView();
        public abstract void BuildBathroom();
        public abstract void BuildBed();

    }

    
}


