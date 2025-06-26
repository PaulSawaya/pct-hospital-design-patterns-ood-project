using System.Text;

namespace OOD_Hospital_Project.BuilderPattern
{
    public class HospitalRoom
    {
        private RoomType roomtype { get; set; }
        public int Bed { get; set; }
        public int Area { get; set; }
        public string Bathroom { get; set; }
        public string View { get; set; }

        public HospitalRoom(RoomType r)
        {
            roomtype = r;
        }

        public string Display()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"The RoomType is {roomtype} \n" +
                $"The number of Bed is {Bed} \n" +
                $"The Area is {Area} m²\n" +
                $"The Bathroom is {Bathroom} \n" +
                $"The View is {View}\n\n");

            return sb.ToString();
            
        }
    }
    
}


