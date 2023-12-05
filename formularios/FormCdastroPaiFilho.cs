using crud.classes;
using System;
using System.Windows.Forms;

namespace crud.formularios
{
    public partial class FormCdastroPaiFilho : Form
    {

        private CadastroPaiFilho cadastro = new CadastroPaiFilho();

        public FormCdastroPaiFilho()
        {
            InitializeComponent();
        }

        // TEXTOS
        private void textBoxId(object sender, EventArgs e)
        {

        }

        private void textBoxNome(object sender, EventArgs e)
        {

        }

        private void textBoxSobrenome(object sender, EventArgs e)
        {

        }

        // BOTOES

        private void buttonNovo(object sender, EventArgs e)
        {
            cadastro.NovoRegistro();
        }

        private void buttonAlterar(object sender, EventArgs e)
        {
            cadastro.GravaRegistro(int.Parse(id.Text), nome.Text, sobrenome.Text);
        }

        private void buttonCancelar(object sender, EventArgs e)
        {

        }

        private void buttonSalvar(object sender, EventArgs e)
        {
            cadastro.GravaRegistro(int.Parse(id.Text), nome.Text, sobrenome.Text);
        }

        private void buttonAnterior(object sender, EventArgs e)
        {
            cadastro.NavegarNosRegistros(int.Parse(id.Text), -1);
        }

        private void buttonProximo(object sender, EventArgs e)
        {
            cadastro.NavegarNosRegistros(int.Parse(id.Text), 1);
        }

        private void buttonExcluir(object sender, EventArgs e)
        {
            cadastro.ExcluiRegistro(int.Parse(id.Text));
        }

        private void buttonSair(object sender, EventArgs e)
        {

        }

        private void buttonReceberPai(object sender, EventArgs e)
        {
            cadastro.recebePai();
        }

    }
}
