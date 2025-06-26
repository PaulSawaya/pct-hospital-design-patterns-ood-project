using OOD_Hospital_Project.Payments;

namespace OOD_Hospital_Project.Entrants
{
    public class OutPatient : Patient
    {
        public int NumberOfTests { get; set; }

        public OutPatient(string name, DateTime dob, string pn, DateTime DA, int NOT) : base(name, dob, pn, DA)
        {
            NumberOfTests = NOT;
        }

        public override void SetPayment(PType p, DateTime Dop)
        {
            float amount = 25 * NumberOfTests;
            payment = new(p, amount, Dop);
        }

        public override string DisplayInfo()
        {
            return $"Entrant Type: OutPatient\n" +
                   $"{base.DisplayInfo()}" +
                   $"Numbers Of Tests to be Done: {NumberOfTests}\n";
        }

    }

}