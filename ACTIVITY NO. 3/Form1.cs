namespace ACTIVITY_NO._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

       

        private void DataSaver_Click(object sender, EventArgs e)
        {
            StreamWriter submit = File.AppendText(@"D:\Users\HP\Downloads\Saved Data\Angel's Burger Customer.txt");
            submit.WriteLine("FULL NAME: " + namePerson2.Text + ", " + namePerson.Text);
            submit.WriteLine("DATE OF BIRTH: " + birthdayPerson.Text);
            submit.WriteLine("AGE: " + agePerson.Text);
            submit.WriteLine("ADDRESS: " + addressBox.Text);
            submit.WriteLine("CONTACT NUMBER:" + contactNumberbox.Text);
          
            //if vaccinated part 1
            if (vaccinebtn1.Checked) ;
            {
                submit.WriteLine("VACCINATED: Yes");

                if (vaccinebtn2.Checked) ;
                submit.WriteLine("VACCINATED: NEH");

                submit.Close();
            }
           

                submit.Close();
            }

        private void nextForm_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }
    }

       
        

          
        }
