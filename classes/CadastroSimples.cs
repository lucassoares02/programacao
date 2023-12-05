using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud.classes
{
    internal class CadastroSimples
    {
        int id;
        String nome;
        String sobrenome;

        public CadastroSimples() { }

        public CadastroSimples(int id, string nome, string sobrenome)
        {
            this.id = id;
            this.nome = nome;
            this.sobrenome = sobrenome;
        }

        // TESTE COMMIT

        // GET E SET
        public int getId()
        {
            return id;
        }
        public void setId(int id)
        {
            this.id = id;
        }

        public String getNome()
        {
            return nome;
        }
        public void setNome(String nome)
        {
            this.nome = nome;
        }
        public String getSobrenome()
        {
            return sobrenome;
        }
        public void setSobrenome(String sobrenome)
        {
            this.sobrenome = sobrenome;
        }


        // METODOS


        public virtual void NovoRegistro()
        {
        }

        public String obterDadosParaPersistir()
        {
            return ($"{id},{nome},{sobrenome}");
        }

        public virtual void GravaRegistro(int id, String nome, String sobrenome)
        {

        }

        public virtual void ExcluiRegistro(int id)
        {

        }

        public virtual Boolean BuscaRegistro(int busca)
        {
            return (id == busca);
        }


        public virtual void NavegarNosRegistros(int id, int operacao)
        {
        }

    }
}
