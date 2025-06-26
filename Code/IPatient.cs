using OOD_Hospital_Project.Payments;

namespace OOD_Hospital_Project.Entrants
{
    public interface IPatient : IEntrants
    {
        public int PatientId { get; set; }
        public Payment payment { get; set; }
        public void SetPayment(PType p, DateTime Dop);
        public string DisplayPatientPaymentInformation();
    }
}