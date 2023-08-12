namespace SlnCorrentista
{
    public partial class frmCorrentista : Form
    {
        Correntista correntista1 = null, correntista2 = null;

        public frmCorrentista()
        {
            InitializeComponent();
        }

        private void frmCorrentista_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            try
            {
                if (correntista1 is null)
                {
                    correntista1 =
                        new Correntista(txtNome.Text, txtCpf.Text,
                        Convert.ToDateTime(dtpDataNascimento.Text),
                        Convert.ToDouble(txtRendaMensal.Text));

                    if (!correntista1.VerificarSeCorrentistaMaior())
                    {
                        throw new Exception("O correntista precisa ser maior de idade!");
                    }
                    MessageBox.Show("Correntista cadastrado com sucesso!!!");
                    btnVerCorrentista1.Visible = true;
                }
                else if (correntista2 is null)
                {
                    correntista2 =
                        new Correntista(txtNome.Text, txtCpf.Text,
                        Convert.ToDateTime(dtpDataNascimento.Text),
                        Convert.ToDouble(txtRendaMensal.Text));

                    if (!correntista2.VerificarSeCorrentistaMaior())
                    {
                        throw new Exception("O correntista precisa ser maior de idade!");
                    }
                    MessageBox.Show("Correntista cadastrado com sucesso!!!");
                    btnVerCorrentista2.Visible = true;
                }
                else
                {
                    MessageBox.Show("Cadastro de Correntistas esgotado!!!");
                }


                txtCpf.Clear();
                txtId.Clear();
                txtNome.Clear();
                txtRendaMensal.Clear();
                dtpDataNascimento.Text = DateTime.Now.ToString();

            }
            catch (FormatException ex)
            {
                MessageBox.Show("Preencha os campos no formato correto");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVerCorrentista1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(correntista1.MontarMensagemDadosCorrentista());
        }

        private void btnVerCorrentista2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(correntista2.MontarMensagemDadosCorrentista());
        }
    }
}