using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEscola
{
    internal class disciplina
    {
        private int id;
        private string nome;
        private int carga;

        public void Setnome(string nome)
        {
            this.nome = nome;
        }

        public string GetNome()
        {
            return this.nome;
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        public int GetId()
        {
            return this.id;
        }

        public void Setcarga(int carga)
        {
            this.carga = carga;
        }

        public int GetCarga()
        {
            return this.carga;
        }

        Conexao bd = new Conexao();

        public void InserirDisciplina()
        {
            string inserir = $"insert into tbldisciplinas values (null, '{this.nome}', '{this.carga}')";
            bd.ExecutarComando(inserir);
        }

        public void AlterarDisciplinas()
        {
            string alterar = $"update tblAlunos set nome = '{this.nome}', carga = '{this.carga}', where id = '{this.id}');";
            bd.ExecutarComando(alterar);
        }

        public void DeletarDisciplinas()
        {
            string deletar = $"delete from tbldisciplinas where id = '{this.id}';";
            bd.ExecutarComando(deletar);
        }

        public DataTable ListarDisciplinas()
        {
            string query = $"select * from tbldisciplinas order by nome;";
            return bd.ExecutarConsulta(query);
        }

    }
}
