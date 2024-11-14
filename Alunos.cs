using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEscola
{
    internal class Alunos
    {
        private int id, idade, serie;
        private string nome;
        private char unidade, turma;

        public void SetId(int id)
        {
            this.id = id;
        }

        public int GetId()
        {
            return this.id;
        }

        public void SetIdade(int idade)
        {
            this.idade = idade;
        }
        public int GetIdade()
        {
            return this.idade;
        }

        public void SetSerie(int serie)
        {
            this.serie = serie;
        }

        public int GetSerie()
        {
            return this.serie;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public string GetNome()
        {
            return this.nome;
        }

        public void SetUnidade(char unidade)
        {
            this.unidade = unidade;
        }

        public int GetUnidade()
        {
            return this.unidade;
        }

        public void SetTurma(char turma)
        {
            this.turma = turma;
        }
        public int GetTurma()
        {
            return this.turma;
        }
        Conexao bd = new Conexao();

        public void InserirAlunos()
        {
            string inserir = $"insert into tblAlunos values (null, '{this.nome}', '{this.idade}', '{this.unidade}', '{this.serie}', '{this.turma}');";
            bd.ExecutarComando(inserir);
        }

        public void AlterarAlunos()
        {
            string alterar = $"update tblAlunos set nome = '{this.nome}', idade = '{this.idade}', unidade = '{this.unidade}', serie = '{this.serie}', turma = '{this.turma}', where id = '{this.id}');";
            bd.ExecutarComando(alterar);
        }

        public void DeletarAlunos()
        {
            string deletar = $"delete from tblAlunos where id = '{this.id}';";
            bd.ExecutarComando(deletar);
        }


    }
}
