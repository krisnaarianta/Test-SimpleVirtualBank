namespace WinFormsApp3_Modul9
{
    public partial class Form1 : Form
    {

        Akun akun1 = new AkunPremium(30000, "halosurabaya");

        //Akun akun1 = new Akun(20000, "halohalobandung");
        public Form1()
        {
            InitializeComponent();
            lblSaldo.Text = akun1.Saldo.ToString();
        }

        private void TarikSaldo(int total)
        {
            akun1.Tarik(total);
            lblSaldo.Text = akun1.Saldo.ToString();
        }

        private void SetorSaldo(int total)
        {
            akun1.Setor(total);
            lblSaldo.Text = akun1.Saldo.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (akun1.PasswordTervalidasi(tbPassword.Text))
            {
                if (rbSetor.Checked)
                    SetorSaldo(int.Parse(tbUang.Text));
                else if (rbTarik.Checked)
                    TarikSaldo(int.Parse(tbUang.Text));
            }
            else
            {
                MessageBox.Show("Password Salah");
            }

        }
    }
}