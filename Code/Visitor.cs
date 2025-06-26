namespace OOD_Hospital_Project.Entrants
{
    public class Visitor : IVisitor
    {
        public string Name { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime VisitDate { get; set; }

        public Visitor(string n, DateTime DOB, string pn, DateTime vd)
        {
            Name = n;
            DateOfBirth = DOB;
            PhoneNumber = pn;
            VisitDate = vd;
        }

        public Visitor(string n, DateTime vd)
        {
            Name = n;
            DateOfBirth = null;
            PhoneNumber = "N/A";
            VisitDate = vd;
        }

        public string DisplayInfo()
        {
            string dateOfBirthString = DateOfBirth.HasValue ? DateOfBirth.Value.ToShortDateString() : "N/A";
            return $"Entrant Type: Visitor\n" +
                   $"Name: {Name}\n" +
                   $"DateOfBirth: {dateOfBirthString}\n" +
                   $"PhoneNumber: {PhoneNumber}\n" +
                   $"Visit Date: {VisitDate.ToShortDateString()}\n";
        }
    }

    
}