using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEscola
{
    public partial class frmAlunos : Form
    {
        public frmAlunos()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Conexao bd = new Conexao();

        private void ExibirDados()
        {
            string query = "select * from tblAlunos order by nome;";
            dtgAlunos.DataSource = bd.ExecutarConsulta(query);
        }

        private void frmAlunos_Load(object sender, EventArgs e)
        {
            ExibirDados();
        }

        Alunos dadosAlunos = new Alunos();

        private void EntradaDeDados()
        {
            char unidade = ' ';
            if (rdbBarroca.Checked)
                unidade = 'B';
            else if (rdbFloresta.Checked)
                unidade = 'F';

            int serie = rdb1Serie.Checked ? 1 : rdb2Serie.Checked ? 2 : rdb3Serie.Checked ? 3 : 0;

            dadosAlunos.SetNome(txtNome.Text);
            dadosAlunos.SetIdade(int.Parse(txtIdade.Text));
            dadosAlunos.SetTurma(char.Parse(cmbTurma.Text));
            dadosAlunos.SetUnidade(unidade);
            dadosAlunos.SetSerie(serie);

        }

        public void btnCadastrar_Click(object sender, EventArgs e)
        {
            EntradaDeDados();
            dadosAlunos.InserirAlunos();
            MessageBox.Show("Dados inseridos com sucesso.");
            ExibirDados();
        }

        private void LimparDados()
        {
            txtID.Clear();
            txtNome.Clear();
            txtIdade.Clear();
            rdb1Serie.Checked = false;
            rdb2Serie.Checked = false;
            rdb3Serie.Checked = false;
            rdbBarroca.Checked = false;
            rdbFloresta.Checked = false;
            cmbTurma.Text = "";

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            dadosAlunos.SetId(int.Parse(txtID.Text));
            EntradaDeDados();
            dadosAlunos.AlterarAlunos();
            MessageBox.Show("Dados alterados com sucesso.");
            ExibirDados();
            LimparDados();

        }

       

        private void dtgAlunos_CellClick(object  sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dtgAlunos.Rows[e.RowIndex].Cells["Id"].Value.ToString();
            txtNome.Text = dtgAlunos.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
            txtIdade.Text = dtgAlunos.Rows[e.RowIndex].Cells["Idade"].Value.ToString();
            cmbTurma.Text = dtgAlunos.Rows[e.RowIndex].Cells["Turma"].Value.ToString();

            if (dtgAlunos.Rows[e.RowIndex].Cells["serie"].Value.ToString() == "1")
                rdb1Serie.Checked = true;
            else if (dtgAlunos.Rows[e.RowIndex].Cells["serie"].Value.ToString() == "2")
                rdb2Serie.Checked = true;
            else if (dtgAlunos.Rows[e.RowIndex].Cells["serie"].Value.ToString() == "3")
                rdb3Serie.Checked = true;

            if (dtgAlunos.Rows[e.RowIndex].Cells["unidade"].Value.ToString() == "B")
                rdbBarroca.Checked = true;
            else if (dtgAlunos.Rows[e.RowIndex].Cells["unidade"].Value.ToString() == "F")
                rdbFloresta.Checked = true;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            dadosAlunos.SetId(int.Parse(txtID.Text));
            dadosAlunos.DeletarAlunos();
            MessageBox.Show("Dados deletados com sucesso.");
            ExibirDados();
            LimparDados();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            this.LimparDados();
        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            EntradaDeDados();
            dadosAlunos.InserirAlunos();
            MessageBox.Show("Dados inseridos com sucesso.");
            ExibirDados();
            LimparDados();
        }
    }
}
