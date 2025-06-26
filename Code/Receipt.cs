using System.Text;

namespace OOD_Hospital_Project.Payments
{
    public class Receipt : IReceipt
    {
        public float Amount { get; set; }
        public DateTime DateOfPayment { get; set; }
        public Receipt(float amount, DateTime dateOfPayment)
        {
            Amount = amount;
            DateOfPayment = dateOfPayment;
        }

        public string DisplayReceipt()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"The Total Amount is {Amount}$\n" +
                $"Date Of Payment: {DateOfPayment.ToShortDateString()}");
            return sb.ToString();
        }

    }

}


