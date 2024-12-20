namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string password="";
        const int limitePW = 5;
        CassettaDiSicurezza cas1= new CassettaDiSicurezza("0001","Xiaomi", "12345", "01234",true);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void btn1_Click(object sender, EventArgs e)
        {   
            if (password.Length < limitePW )
            {
                password += 1;
                label1.Text = password;
            }

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (password.Length < limitePW)
            {
                password += 2;
                label1.Text = password;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (password.Length < limitePW)
            {
                password += 3;
                label1.Text = password;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (password.Length < limitePW)
            {
                password += 4;
                label1.Text = password;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (password.Length < limitePW)
            {
                password += 5;
                label1.Text = password;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (password.Length < limitePW)
            {
                password += 6;
                label1.Text = password;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (password.Length < limitePW)
            {
                password += 7;
                label1.Text = password;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (password.Length < limitePW)
            {
                password += 8;
                label1.Text = password;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (password.Length < limitePW)
            {
                password += 9;
                label1.Text = password;
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (password.Length < limitePW)
            {
                password += 0;
                label1.Text = password;
            }
        }

        private void confermabtn_Click(object sender, EventArgs e)
        {

        }

    }
}
