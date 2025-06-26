namespace OOD_Hospital_Project.BuilderPattern
{
    public class RegularHospitalRoom : HospitalRoomBuilder
    {
        public RegularHospitalRoom()
        {
            Room = new HospitalRoom(RoomType.Regular);
        }
        public override void BuildArea()
        {
            Room.Area = 10;
        }
        public override void BuildView()
        {
            Room.View = "Regular View";
        }
        public override void BuildBathroom()
        {
            Room.Bathroom = "Simple Bathroom";
        }
        public override void BuildBed()
        {
            Room.Bed = 2;
        }
    }

    
}


