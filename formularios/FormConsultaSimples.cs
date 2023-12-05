using crud.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud.formularios
{
    public partial class FormConsultaSimples : Form
    {

        private ConsultaSimples consulta = new ConsultaSimples();

        public FormConsultaSimples()
        {
            InitializeComponent();
        }

        // BOTOES

        private void buttonBuscar(object sender, EventArgs e)
        {
            consulta.Filtrar(busca.Text);
        }

        private void textBoxBusca(object sender, EventArgs e)
        {

        }

        // LABELS

        private void labelBuscar(object sender, EventArgs e)
        {

        }

        // GRADE DE DADOS

        private void dataGrid(object sender, DataGridViewCellEventArgs e)
        {

        }

        // BOTOES

        private void buttonIncluir(object sender, EventArgs e)
        {
            consulta.Incluir();
        }

        private void buttonAlterar(object sender, EventArgs e)
        {
            consulta.Alterar();
        }

        private void buttonSair(object sender, EventArgs e)
        {

        }
    }
}
