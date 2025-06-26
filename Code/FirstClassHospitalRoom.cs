namespace OOD_Hospital_Project.BuilderPattern
{
    public class FirstClassHospitalRoom : HospitalRoomBuilder
    {
        public FirstClassHospitalRoom()
        {
            Room = new HospitalRoom(RoomType.FirstClass);
        }
        public override void BuildArea()
        {
            Room.Area = 20;
        }
        public override void BuildView()
        {
            Room.View = "Beautiful View";
        }
        public override void BuildBathroom()
        {
            Room.Bathroom = "Deluxe Bathroom";
        }
        public override void BuildBed()
        {
            Room.Bed = 1;
        }
    }
    
}


