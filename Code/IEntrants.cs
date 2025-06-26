namespace OOD_Hospital_Project.Entrants
{
        public interface IEntrants
        {
        public string Name { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        string DisplayInfo();
        }

    
}