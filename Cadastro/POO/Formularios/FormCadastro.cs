using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO.Classes;
using System.Windows.Forms;

namespace POO.Formularios
{
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            //Cria a instância da classe Professor
            //Observe a inclusão do using nas linhas iniciais...
            //
            ClsProfessor ObjProfessor = new ClsProfessor();
            //Envia informações para a classe professor
            ObjProfessor.Cpf = TxtCpfProfessor.Text;
            ObjProfessor.Nome = TxtNomePro.Text;
            ObjProfessor.Endereco = TxtEnderecoPro.Text;
            ObjProfessor.Licenciatura = TxtLicenciatura.Text;
            ObjProfessor.Categoria = TxtCategoria.Text;
            //executa o método incluir (sobrescrito) da classe Professor
            LblStatus.Text = ObjProfessor.Incluir();

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            TxtCpfProfessor.Text = "";
            TxtNomePro.Text = "";
            TxtEnderecoPro.Text = "";
            TxtLicenciatura.Text= "";
            TxtCategoria.Text = "";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LblStatus.Text = "";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TabPage2_Click(object sender, EventArgs e)
        {

        }

        private void BtnIncluir2_Click(object sender, EventArgs e)
        {

            ClsAluno ObjAluno = new ClsAluno();

            ObjAluno.Cpf = TxtCpfAluno.Text;
            ObjAluno.Nome = TxtNomealuno.Text;
            ObjAluno.Endereco = TxtEnderecoaluno.Text;
            ObjAluno.Turma1 = TxtTurmaAluno.Text;
            ObjAluno.Curso1 = TxtCursoAluno.Text;
            //executa o método incluir (sobrescrito) da classe Professor
            LblStatus.Text = ObjAluno.Incluir();
        }

        private void BtnExcluir2_Click(object sender, EventArgs e)
        {
           


        }

    }
}

