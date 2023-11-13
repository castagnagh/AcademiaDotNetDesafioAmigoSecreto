namespace AmigoSecretoWinForms
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;

        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            this.Hide();


            Form2 form2 = new Form2();
            form2.FormClosed += (s, args) => this.Close();
            form2.Show();
        }
    }
}