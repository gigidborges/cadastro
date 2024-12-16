using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POO.Formularios;

namespace POO
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void Mnusair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Mnucadastro_Click(object sender, EventArgs e)
        {
            FrmCadastro MeuCadastro = new FrmCadastro();
            MeuCadastro.MdiParent = this;
            MeuCadastro.Show();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
