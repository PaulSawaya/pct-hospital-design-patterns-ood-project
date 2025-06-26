using System;
using System.Text;

using OOD_Hospital_Project.AdapterPattern;
using OOD_Hospital_Project.SingletonPattern;
using OOD_Hospital_Project.BuilderPattern;
using OOD_Hospital_Project.Payments;
using OOD_Hospital_Project.Entrants;


namespace OOD_Proj_Final
{
    public partial class Form1 : Form
    {
        IEntrants Visitor1 = new Visitor("Paul S.", new DateTime(1999, 12, 23), "+961 3 333444", new DateTime(2024, 6, 5));
        IEntrants Visitor2 = new Visitor("Tiana C.", new DateTime(2004, 3, 1), "+961 3 322508", new DateTime(2019, 3, 2));
        IEntrants VisitorWihoutBirthDate = new Visitor("Charbel k.", new DateTime(2024, 5, 13));
        IPatient Patient1 = new InPatient("Jane BD.", new DateTime(1997, 9, 17), "+961 1 223377", new DateTime(2020, 4, 5), true, new DateTime(2020, 4, 15));
        IPatient Patient2 = new InPatient("Jad K.", new DateTime(2011, 6, 8), "+961 7 228899", new DateTime(2019, 7, 9), false, new DateTime(2019, 8, 10));
        IPatient Patient3 = new OutPatient("Tony H.", new DateTime(2015, 3, 6), "+961 3 765456", new DateTime(2024, 4, 4), 3);

        public Form1()
        {
            InitializeComponent();
            Patient1.SetPayment(PType.Cash, new DateTime(2002, 9, 8));
            Patient2.SetPayment(PType.WHISH, new DateTime(2019, 8, 5));
            Patient3.SetPayment(PType.OMT, new DateTime(2024, 4, 4));
            var HospitalInstance = Hospital.GetInstance();

            HospitalInstance.AddToList(Visitor1);
            HospitalInstance.AddToList(Visitor2);
            HospitalInstance.AddToList(VisitorWihoutBirthDate);
            HospitalInstance.AddToList(Patient1);
            HospitalInstance.AddToList(Patient2);
            HospitalInstance.AddToList(Patient3);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "PCT Hospital NDU Branch By Your Side!";
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            StringBuilder sb = new();
            sb.Append($"Name of the Hospital: {Hospital.GetInstance().HospitalName} \n" +
                $"Hospital Location: {Hospital.GetInstance().HospitalLocation} \n" +
                $"Hospital Phone Number: {Hospital.GetInstance().HospitalPhoneNumber}");
            MessageBox.Show(sb.ToString(), "Hospital Information");
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
            SystemConnector systemConnector = new HospitalManagementSystemConnector();
            Hospital.GetInstance().ExportData(systemConnector);
            string result = Hospital.GetInstance().DisplayPatientRecords(systemConnector);
            MessageBox.Show(result, "Entrants Details");

        }

        private void button3_Click(object sender, EventArgs e)
        {

            HospitalRoomBuilder H1 = new RegularHospitalRoom();
            Hospital.GetInstance().Construct(H1);

            HospitalRoomBuilder H2 = new FirstClassHospitalRoom();
            Hospital.GetInstance().Construct(H2);

            string result = H1.Room.Display() +H2.Room.Display();
            MessageBox.Show(result, "Hospital Rooms");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            StringBuilder PaymentResults = new();
            PaymentResults.Append(
             $"{Patient1.DisplayPatientPaymentInformation()}" +
              $"{Patient2.DisplayPatientPaymentInformation()}" +
             $"{Patient3.DisplayPatientPaymentInformation()}"
                            );
            MessageBox.Show(PaymentResults.ToString(), "Payment Details");
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}