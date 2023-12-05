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
    public partial class FormConsultaPaiFilho : Form
    {

        private ConsultaPaiFilho consulta = new ConsultaPaiFilho();
        
        public FormConsultaPaiFilho()
        {
            InitializeComponent();
        }

        // TEXTOS
        private void textBoxBusca(object sender, EventArgs e)
        {

        }

        // BOTOES

        private void buttonBuscar(object sender, EventArgs e)
        {
            consulta.Filtrar(busca.Text);
        }

        private void buttonSair(object sender, EventArgs e)
        {

        }

        private void buttonAlterar(object sender, EventArgs e)
        {
            consulta.Alterar();
        }

        private void buttonIncluir(object sender, EventArgs e)
        {
            consulta.Incluir();
        }

        private void buttonReceberPai(object sender, EventArgs e)
        {
            consulta.recebePai();
        }


        // GRADE DE DADOS

        private void dataGrid(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
