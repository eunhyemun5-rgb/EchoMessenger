namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void 전송_Click(object sender, EventArgs e)
        {
            string typed_msg = textBox1.Text;
            Echowindow.Items.Add(typed_msg);
            textBox1.Clear();

            string time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); string msg = "Hello"; string result = time + " " + msg;
        }
    }
}
       
