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
            StreamWriter save = new StreamWriter(@"D:\Users\HP\Downloads\Saved Data\person.txt");
            save.WriteLine("hi");
            save.Close();

        }

        private void officialweb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          
        }

        private void typeService_Click(object sender, EventArgs e)
        {

        }
    }
}