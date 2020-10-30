using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_escolar_RP
{
    public partial class frmAlunos : Form
    {
        public frmAlunos()
        {
            InitializeComponent();
        }

        ConexaoBD bd = new ConexaoBD();
        string sql;
        DateTime data;

        public void limpar()
        {
            txtMatricula.Clear();
            txtNome.Clear();
            txtNota.Clear();
            cbxSexo.SelectedIndex = -1;
            dtpData.Text = DateTime.Now.ToString();
        }

        public void Listar()
        {
            sql = "select * from alunos";
            dtgListar.DataSource = bd.ConsultarDados(sql);
        }

        private void frmAlunos_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void lblMatricula_Click(object sender, EventArgs e)
        {

        }

        private void txtMatricula_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblData_Click(object sender, EventArgs e)
        {

        }

        private void lblSexo_Click(object sender, EventArgs e)
        {

        }

        private void lblNota_Click(object sender, EventArgs e)
        {

        }

        private void dtgListar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMatricula.Text = dtgListar.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = dtgListar.Rows[e.RowIndex].Cells[1].Value.ToString();
            dtpData.Text = dtgListar.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbxSexo.Text = dtgListar.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtNota.Text = dtgListar.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void dtpData_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbxSexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNota_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            sql = string.Format("select * from alunos where matricula = '{0}'", txtMatricula.Text);
            dt = bd.ConsultarDados(sql);

            if(dt.Rows.Count > 0)
            {
                txtMatricula.Text = dt.Rows[0]["matricula"].ToString();
                txtNome.Text = dt.Rows[0]["nome"].ToString();
                txtNota.Text = dt.Rows[0]["nota"].ToString();
                cbxSexo.Text = dt.Rows[0]["sexo"].ToString();
                dtpData.Text = dt.Rows[0]["dt_nasc"].ToString();
            } 
            else
            {
                MessageBox.Show("Aluno não cadastrado!","Alunos",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            sql = string.Format("update alunos set nome = '{0}', nota = '{1}', dt_nasc = '{2}', sexo = '{3}' where matricula = '{4}'"
                ,txtNome.Text, txtNota.Text, data.ToString("yyyy-MM-dd"),cbxSexo.Text, txtMatricula.Text);
            bd.AlterarDados(sql);

            MessageBox.Show("Dados do aluno alterado com sucesso!", "Alunos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpar();
            Listar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            sql = string.Format("delete from alunos where matricula = '{0}'", txtMatricula.Text);
            bd.AlterarDados(sql);

            MessageBox.Show("Dados do aluno excluido com sucesso!", "Alunos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpar();
            Listar();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            data = DateTime.Parse(dtpData.Text);

            sql = string.Format("insert into alunos values(null,'{0}','{1}','{2}','{3}')",txtNome.Text, data.ToString("yyyy-MM-dd"),cbxSexo.Text,txtNota.Text);
            bd.AlterarDados(sql);
            MessageBox.Show("Cadastro do aluno efetuado com sucesso!","Aluno",MessageBoxButtons.OK,MessageBoxIcon.Information);
            limpar();
            Listar();
        }
    }
}
