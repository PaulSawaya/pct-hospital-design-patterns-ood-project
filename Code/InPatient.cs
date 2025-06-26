using OOD_Hospital_Project.Payments;

namespace OOD_Hospital_Project.Entrants
{
    public class InPatient : Patient
    {
        public bool IsMonitored { get; set; }
        public int NumberOfStayInDays { get; set; }
        public DateTime CheckOutDate { get; set; }
        public InPatient(string name, DateTime dob, string pn, DateTime DA, bool Im, DateTime checkOutDate) : base(name, dob, pn, DA)
        {
            IsMonitored = Im;
            CheckOutDate = checkOutDate;

            NumberOfStayInDays = (checkOutDate - DA).Days;
        }

        public override void SetPayment(PType p, DateTime Dop)
        {
            if (IsMonitored == true)
            {
                float amount = 100 * NumberOfStayInDays;
                payment = new(p, amount, Dop);
            }
            else {
                float amount = 80 * NumberOfStayInDays;
                payment = new(p, amount, Dop);
            }
        }

        public override string DisplayInfo()
        {
            return $"Entrant Type: InPatient\n" +
                   $"{base.DisplayInfo()}" +
                   $"Duration Of Stay: {NumberOfStayInDays} Days\n";
        }
    }

    
}


