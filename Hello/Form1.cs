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
            lblResult.Text = a.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
