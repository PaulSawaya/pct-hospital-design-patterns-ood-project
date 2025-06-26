using OOD_Hospital_Project.Payments;

namespace OOD_Hospital_Project.Entrants
{
    public class Patient : IPatient
    {
        public int PatientId { get; set; }
        public string Name { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfAdmission { get; set; }
        public Payment payment { get; set; }
        static int number = 1;

        public Patient(string name, DateTime dob, string pn, DateTime DA)
        {
            PatientId = number;
            Name = name;
            DateOfBirth = dob;
            PhoneNumber = pn;
            DateOfAdmission = DA;
            number++;
        }

        public virtual void SetPayment(PType p, DateTime Dop)
        {
            
        }

        public string DisplayPatientPaymentInformation()
        {
            string result = $"Patient Id: {PatientId} \n{payment.DisplayPaymentInformation()}";
            return result;
        }

        public virtual string DisplayInfo()
        {
            string dateOfBirthString = DateOfBirth.HasValue ? DateOfBirth.Value.ToShortDateString() : "N/A";
            return $"Name: {Name}\n" +
                $"DateOfBirth: {dateOfBirthString}\n" +
                $"PhoneNumber: {PhoneNumber}\n";
        }

    }
}