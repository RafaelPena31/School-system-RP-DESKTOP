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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void ptx_alunos_Click(object sender, EventArgs e)
        {
            frmAlunos alunos = new frmAlunos();
            alunos.ShowDialog();
        }
    }
}
