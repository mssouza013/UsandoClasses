namespace UsandoClasses
{
    public partial class frmCalculoMedia : Form
    {
        public frmCalculoMedia()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //instancie Classe.
            Aluno alun = new Aluno();

            // atribui as propriedades.
            alun.Nome = txtNome.Text;
            alun.Ra = txtRa.Text;
            alun.P1 = double.Parse(txtP1.Text);
            alun.P2 = double.Parse(txtP2.Text);

            alun.CalcularMedia();

            lblMedia.Visible = true;
            txtMedia.Visible = true;
            txtMedia.Text = alun.Media.ToString("n2");
        }

        private void frmCalculoMedia_Load(object sender, EventArgs e)
        {
            txtMedia.Visible = false;
            lblMedia.Visible = false;
        }
    }
}