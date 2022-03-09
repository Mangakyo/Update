using System.Net;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        WebClient client = new WebClient();
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (client.DownloadString("https://pastebin.com/MYX6bkvd").Contains("2.2"))
        {
                MessageBox.Show("Последняя версия версия программы", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
        }
            else
        {
                MessageBox.Show("Старая версия программы", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
        }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            client.DownloadFile("", "update.exe");
        }
    }
}