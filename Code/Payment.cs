using System.Text;

namespace OOD_Hospital_Project.Payments
{
    public class Payment
    {
        IReceipt receipt;
        public PType PaymentType { get; set; }


        public Payment(PType p, float amount, DateTime Dop)
        {
            PaymentType = p;
            SetReceiptInformation(amount, Dop);

        }

        public void SetReceiptInformation(float amount, DateTime Dop)
        {
            receipt = new Receipt(amount, Dop);
        }

        public string DisplayPaymentInformation()
        {
            StringBuilder sb = new();
            string oldresult = receipt.DisplayReceipt();
            sb.Append($"{oldresult} \nThe Payment Type is {PaymentType}\n\n");
            return sb.ToString();
        }

    }

    
}


