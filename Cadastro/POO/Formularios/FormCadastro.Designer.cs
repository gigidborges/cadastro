namespace POO.Formularios
{
    partial class FrmCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Info = new System.Windows.Forms.GroupBox();
            this.TxtCategoria = new System.Windows.Forms.TextBox();
            this.TxtLicenciatura = new System.Windows.Forms.TextBox();
            this.TxtEnderecoPro = new System.Windows.Forms.TextBox();
            this.TxtNomePro = new System.Windows.Forms.TextBox();
            this.TxtCpfProfessor = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BtnExcluir2 = new System.Windows.Forms.Button();
            this.BtnIncluir2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtTurmaAluno = new System.Windows.Forms.TextBox();
            this.TxtCursoAluno = new System.Windows.Forms.TextBox();
            this.TxtEnderecoaluno = new System.Windows.Forms.TextBox();
            this.TxtNomealuno = new System.Windows.Forms.TextBox();
            this.TxtCpfAluno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LblStatus = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.Info.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(44, 18);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(649, 369);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tabPage1.Controls.Add(this.Info);
            this.tabPage1.Controls.Add(this.btnExcluir);
            this.tabPage1.Controls.Add(this.btnIncluir);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(641, 343);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Professores";
            this.tabPage1.Click += new System.EventHandler(this.TabPage1_Click);
            // 
            // Info
            // 
            this.Info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Info.Controls.Add(this.TxtCategoria);
            this.Info.Controls.Add(this.TxtLicenciatura);
            this.Info.Controls.Add(this.TxtEnderecoPro);
            this.Info.Controls.Add(this.TxtNomePro);
            this.Info.Controls.Add(this.TxtCpfProfessor);
            this.Info.Location = new System.Drawing.Point(174, 10);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(447, 222);
            this.Info.TabIndex = 15;
            this.Info.TabStop = false;
            this.Info.Text = "groupBox1";
            // 
            // TxtCategoria
            // 
            this.TxtCategoria.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCategoria.Location = new System.Drawing.Point(6, 177);
            this.TxtCategoria.Name = "TxtCategoria";
            this.TxtCategoria.Size = new System.Drawing.Size(435, 29);
            this.TxtCategoria.TabIndex = 16;
            // 
            // TxtLicenciatura
            // 
            this.TxtLicenciatura.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLicenciatura.Location = new System.Drawing.Point(6, 142);
            this.TxtLicenciatura.Name = "TxtLicenciatura";
            this.TxtLicenciatura.Size = new System.Drawing.Size(435, 29);
            this.TxtLicenciatura.TabIndex = 3;
            this.TxtLicenciatura.TextChanged += new System.EventHandler(this.TextBox4_TextChanged);
            // 
            // TxtEnderecoPro
            // 
            this.TxtEnderecoPro.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEnderecoPro.Location = new System.Drawing.Point(6, 102);
            this.TxtEnderecoPro.Name = "TxtEnderecoPro";
            this.TxtEnderecoPro.Size = new System.Drawing.Size(435, 29);
            this.TxtEnderecoPro.TabIndex = 2;
            // 
            // TxtNomePro
            // 
            this.TxtNomePro.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNomePro.Location = new System.Drawing.Point(6, 63);
            this.TxtNomePro.Name = "TxtNomePro";
            this.TxtNomePro.Size = new System.Drawing.Size(435, 29);
            this.TxtNomePro.TabIndex = 1;
            // 
            // TxtCpfProfessor
            // 
            this.TxtCpfProfessor.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCpfProfessor.Location = new System.Drawing.Point(6, 26);
            this.TxtCpfProfessor.Name = "TxtCpfProfessor";
            this.TxtCpfProfessor.Size = new System.Drawing.Size(435, 29);
            this.TxtCpfProfessor.TabIndex = 0;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(351, 280);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(85, 33);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluir.Location = new System.Drawing.Point(188, 280);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(85, 33);
            this.btnIncluir.TabIndex = 13;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.BtnIncluir_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Categoria:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Licenciatura:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "Endereço:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nome:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "CPF:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tabPage2.Controls.Add(this.BtnExcluir2);
            this.tabPage2.Controls.Add(this.BtnIncluir2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(641, 343);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Alunos";
            this.tabPage2.Click += new System.EventHandler(this.TabPage2_Click);
            // 
            // BtnExcluir2
            // 
            this.BtnExcluir2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluir2.Location = new System.Drawing.Point(444, 276);
            this.BtnExcluir2.Name = "BtnExcluir2";
            this.BtnExcluir2.Size = new System.Drawing.Size(85, 33);
            this.BtnExcluir2.TabIndex = 19;
            this.BtnExcluir2.Text = "Excluir";
            this.BtnExcluir2.UseVisualStyleBackColor = true;
            this.BtnExcluir2.Click += new System.EventHandler(this.BtnExcluir2_Click);
            // 
            // BtnIncluir2
            // 
            this.BtnIncluir2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIncluir2.Location = new System.Drawing.Point(123, 276);
            this.BtnIncluir2.Name = "BtnIncluir2";
            this.BtnIncluir2.Size = new System.Drawing.Size(85, 33);
            this.BtnIncluir2.TabIndex = 18;
            this.BtnIncluir2.Text = "Incluir";
            this.BtnIncluir2.UseVisualStyleBackColor = true;
            this.BtnIncluir2.Click += new System.EventHandler(this.BtnIncluir2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.TxtTurmaAluno);
            this.groupBox1.Controls.Add(this.TxtCursoAluno);
            this.groupBox1.Controls.Add(this.TxtEnderecoaluno);
            this.groupBox1.Controls.Add(this.TxtNomealuno);
            this.groupBox1.Controls.Add(this.TxtCpfAluno);
            this.groupBox1.Location = new System.Drawing.Point(175, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 222);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // TxtTurmaAluno
            // 
            this.TxtTurmaAluno.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTurmaAluno.Location = new System.Drawing.Point(6, 177);
            this.TxtTurmaAluno.Name = "TxtTurmaAluno";
            this.TxtTurmaAluno.Size = new System.Drawing.Size(435, 29);
            this.TxtTurmaAluno.TabIndex = 16;
            // 
            // TxtCursoAluno
            // 
            this.TxtCursoAluno.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCursoAluno.Location = new System.Drawing.Point(6, 142);
            this.TxtCursoAluno.Name = "TxtCursoAluno";
            this.TxtCursoAluno.Size = new System.Drawing.Size(435, 29);
            this.TxtCursoAluno.TabIndex = 3;
            // 
            // TxtEnderecoaluno
            // 
            this.TxtEnderecoaluno.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEnderecoaluno.Location = new System.Drawing.Point(6, 102);
            this.TxtEnderecoaluno.Name = "TxtEnderecoaluno";
            this.TxtEnderecoaluno.Size = new System.Drawing.Size(435, 29);
            this.TxtEnderecoaluno.TabIndex = 2;
            // 
            // TxtNomealuno
            // 
            this.TxtNomealuno.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNomealuno.Location = new System.Drawing.Point(6, 63);
            this.TxtNomealuno.Name = "TxtNomealuno";
            this.TxtNomealuno.Size = new System.Drawing.Size(435, 29);
            this.TxtNomealuno.TabIndex = 1;
            // 
            // TxtCpfAluno
            // 
            this.TxtCpfAluno.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCpfAluno.Location = new System.Drawing.Point(6, 26);
            this.TxtCpfAluno.Name = "TxtCpfAluno";
            this.TxtCpfAluno.Size = new System.Drawing.Size(435, 29);
            this.TxtCpfAluno.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 23);
            this.label7.TabIndex = 17;
            this.label7.Text = "Turma:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(37, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 23);
            this.label8.TabIndex = 16;
            this.label8.Text = "Curso:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(37, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 26);
            this.label9.TabIndex = 15;
            this.label9.Text = "Endereço:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(37, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 14;
            this.label10.Text = "Nome:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(37, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 23);
            this.label11.TabIndex = 13;
            this.label11.Text = "CPF:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 420);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 16;
            this.label6.Text = "Status:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblStatus
            // 
            this.LblStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.LblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblStatus.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblStatus.Location = new System.Drawing.Point(109, 420);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(569, 161);
            this.LblStatus.TabIndex = 16;
            this.LblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(183, 731);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 33);
            this.button3.TabIndex = 16;
            this.button3.Text = "Limpar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(517, 731);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 33);
            this.button4.TabIndex = 16;
            this.button4.Text = "Fecha";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(15, 476);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 33);
            this.button1.TabIndex = 16;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(15, 547);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 33);
            this.button2.TabIndex = 17;
            this.button2.Text = "Fecha";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 624);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.LblStatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "FrmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.Info.ResumeLayout(false);
            this.Info.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox Info;
        private System.Windows.Forms.TextBox TxtCpfProfessor;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox TxtCategoria;
        private System.Windows.Forms.TextBox TxtLicenciatura;
        private System.Windows.Forms.TextBox TxtEnderecoPro;
        private System.Windows.Forms.TextBox TxtNomePro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtTurmaAluno;
        private System.Windows.Forms.TextBox TxtCursoAluno;
        private System.Windows.Forms.TextBox TxtEnderecoaluno;
        private System.Windows.Forms.TextBox TxtNomealuno;
        private System.Windows.Forms.TextBox TxtCpfAluno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnExcluir2;
        private System.Windows.Forms.Button BtnIncluir2;
    }
}