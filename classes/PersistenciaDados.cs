using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud.classes
{
    internal class PersistenciaDados
    {
        private String caminho;

        public PersistenciaDados(String nome)
        {
            caminho = nome;
        }

        public void salvar(List<CadastroSimples> dados)
        {
            using (StreamWriter writer = new StreamWriter(caminho))
            {
                foreach (CadastroSimples cadastro in dados)
                {
                    writer.WriteLine(cadastro.obterDadosParaPersistir());
                }
            }
        }

        public List<CadastroSimples> listar()
        {
            List<CadastroSimples> dados = new List<CadastroSimples>();

            if (File.Exists(caminho))
            {
                using (StreamReader reader = new StreamReader(caminho))
                {
                    string linha;
                    while ((linha = reader.ReadLine()) != null)
                    {
                        string[] partes = linha.Split(',');
                        if (partes.Length == 3)
                        {
                            int id = int.Parse(partes[0]);
                            string nome = partes[1];
                            string sobrenome = partes[2];
                            CadastroSimples cadastro = new CadastroSimples(id,nome,sobrenome);
                            dados.Add(cadastro);
                        }
                    }
                }
            }
            return dados;
        }


        public void excluir(int id)
        {
            List<CadastroSimples> dados = new List<CadastroSimples>();
            CadastroSimples cadastroParaExcluir = dados.Find(c => c.getId() == id);

            if (cadastroParaExcluir != null)
            {
                dados.Remove(cadastroParaExcluir);
                salvar(dados);
            }
        }

        public void atualizar(CadastroSimples atualiza){

            List<CadastroSimples> dados = new List<CadastroSimples>();
            CadastroSimples cadastroExistente = dados.Find(c => c.getId() == atualiza.getId());

            if (cadastroExistente != null)
            {
                cadastroExistente.setNome(atualiza.getNome());
                cadastroExistente.setSobrenome(atualiza.getSobrenome());
                salvar(dados);

            }


        }


    }
}
