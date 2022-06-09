namespace ACTIVITY_NO._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataSaver_Click(object sender, EventArgs e)
        {
            StreamWriter submit = File.AppendText(@"D:\Users\HP\Downloads\Saved Data\Angel's Burger Customer.txt");
            submit.WriteLine("FULL NAME: " + namePerson2.Text + ", " + namePerson.Text);
            submit.WriteLine("DATE OF BIRTH: " + birthdayPerson.Text);
            submit.WriteLine("AGE: " + agePerson.Text);
            submit.WriteLine("ADDRESS: " + addressBox.Text);
            submit.WriteLine("CONTACT NUMBER:" + contactNumberbox.Text);
            submit.WriteLine("");
            submit.Close();

        }

        private void officialweb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          
        }

        private void typeService_Click(object sender, EventArgs e)
        {

        }
    }
}