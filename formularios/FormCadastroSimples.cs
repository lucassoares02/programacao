using crud.classes;
using System;
using System.Windows.Forms;

namespace crud.formularios
{
    public partial class FormCadastroSimples : Form
    {

        private CadastroSimples cadastro = new CadastroSimples();
        

        
        public FormCadastroSimples()
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

        private void btnSalvar(object sender, EventArgs e)
        {
            Console.WriteLine("Salva Registro!");
            cadastro.GravaRegistro(int.Parse(id.Text), nome.Text, sobrenome.Text);
        }

        private void buttonSair(object sender, EventArgs e)
        {

        }

        private void buttonExcluir(object sender, EventArgs e)
        {
            cadastro.ExcluiRegistro(int.Parse(id.Text));
        }

        private void buttonAnterior(object sender, EventArgs e)
        {
            cadastro.NavegarNosRegistros(int.Parse(id.Text), -1);

        }

        private void buttonProximo(object sender, EventArgs e)
        {
            cadastro.NavegarNosRegistros(int.Parse(id.Text), 1);
        }

        private void buttonCancelar(object sender, EventArgs e)
        {
            id.Text = "";
            nome.Text = "";
            sobrenome.Text = "";
        }

        private void buttonNovo(object sender, EventArgs e)
        {
            Console.WriteLine("Novo Registro!");
            cadastro.NovoRegistro();
        }

        private void buttonAlterar(object sender, EventArgs e)
        {
            cadastro.GravaRegistro(int.Parse(id.Text), nome.Text, sobrenome.Text);
        }


        // LABELS
        private void labelId(object sender, EventArgs e)
        {

        }


        private void labelSobrenome(object sender, EventArgs e)
        {

        }

        private void labelNome(object sender, EventArgs e)
        {

        }


    }
}
