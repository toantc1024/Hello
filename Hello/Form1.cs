using System.Diagnostics;
namespace Hello
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clicked!");
            int a = 3;
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("holo!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("Notepad.exe");
        }
    }
}
