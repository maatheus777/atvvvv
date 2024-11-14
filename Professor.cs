using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEscola
{
    internal class Professor
    {
        private int id;
        private string nome, cpf, tele, escolaridade, Disciplina;
        private int carga;
        private DateTime dtAdmissao;
        private char turno;

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

        public void Setcpf(string cpf)
        {
            this.cpf = cpf;
        }

        public string GetCpf()
        {
            return this.cpf;
        }

        public void Settele(string tele)
        {
            this.tele = tele;
        }

        public string GetTele()
        {
            return this.tele;
        }

        public void Setescolaridade(string escolaridade)
        {
            this.escolaridade = escolaridade;
        }

        public string GetEscolaridade()
        {
            return this.escolaridade;
        }

        public void SetDisciplina(string Disciplina)
        {
            this.Disciplina = Disciplina;
        }

        public string GetDisciplina()
        {
            return this.Disciplina;
        }

        public void SetEscolaridade(string escolaridade)
        {
            this.escolaridade = escolaridade;
        }

        public string Getescolaridade()
        {
            return this.escolaridade;
        }

        public void Setturno(char turno)
        {
            this.turno = turno;
        }

        public char GetTurno ()
        {
            return this.turno;
        }

        public void SetAdmissao(DateTime dtAdmissao)
        {
            this.dtAdmissao = dtAdmissao;
        }

        public DateTime GetAdmissao()
        {
            return this.dtAdmissao;
        }

        Conexao bd = new Conexao();

        public void InserirProfessor()
        {
            string inserir = $"inset into tblProfessor values (null, '{this.nome}', '{this.dtAdmissao}', '{this.turno}', '{this.Disciplina}', '{this.escolaridade}', '{this.cpf}', '{this.tele}');";
            bd.ExecutarComando(inserir);
        }

        public void AlterarProfessor()
        {
            string alterar = $"update tblProfessor set nome = '{this.nome}', '{this.dtAdmissao}', '{this.turno}', '{this.Disciplina}', '{this.escolaridade}', '{this.cpf}', '{this.tele}, where id = '{this.id}');";
            bd.ExecutarComando(alterar);
        }

        public void DeletarProfessor()
        {
            string deletar = $"delete from tblProfessor where id = '{this.id}';";
            bd.ExecutarComando(deletar);
        }

    }
}
