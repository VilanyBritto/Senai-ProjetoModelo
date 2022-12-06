namespace AppModelo.View.Windows.Cadastro
{
    partial class frmCadastroFuncionario
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEnderecoLogradouro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEnderecoNumero = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEnderecoComplemento = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEnderecoBairro = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtEnderecoMunicipio = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEnderecoUf = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbFeminino = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbNacionalidade = new System.Windows.Forms.ComboBox();
            this.cmbNaturalidade = new System.Windows.Forms.ComboBox();
            this.txtTelefoneContato = new System.Windows.Forms.MaskedTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnPesquisarCep = new System.Windows.Forms.Button();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnAtualizarFuncionario = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPesquisarIdFuncionario = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 103);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTRO DE FUNCIONÁRIOS";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(17, 156);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(72, 32);
            this.txtId.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nome completo";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(254, 156);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(386, 32);
            this.txtNome.TabIndex = 0;
            this.txtNome.Tag = "Obrigatorio";
            this.txtNome.Validating += new System.ComponentModel.CancelEventHandler(this.txtNome_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "CPF";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(197, 237);
            this.txtCpf.Mask = "###,###,###-##";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(154, 32);
            this.txtCpf.TabIndex = 3;
            this.txtCpf.Tag = "Obrigatorio";
            this.txtCpf.Validating += new System.ComponentModel.CancelEventHandler(this.txtCpf_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Data de nascimento";
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Location = new System.Drawing.Point(17, 238);
            this.txtDataNascimento.Mask = "00/00/0000";
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(154, 32);
            this.txtDataNascimento.TabIndex = 1;
            this.txtDataNascimento.Tag = "Obrigatorio";
            this.txtDataNascimento.ValidatingType = typeof(System.DateTime);
            this.txtDataNascimento.Validated += new System.EventHandler(this.txtDataNascimento_Validated);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(17, 315);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(277, 32);
            this.txtEmail.TabIndex = 6;
            this.txtEmail.Tag = "Obrigatorio";
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "E-mail";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(314, 315);
            this.txtTelefone.Mask = "(##)#####-####";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(154, 32);
            this.txtTelefone.TabIndex = 7;
            this.txtTelefone.Tag = "Obrigatorio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(314, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Telefone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 374);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "CEP";
            // 
            // txtEnderecoLogradouro
            // 
            this.txtEnderecoLogradouro.Enabled = false;
            this.txtEnderecoLogradouro.Location = new System.Drawing.Point(17, 466);
            this.txtEnderecoLogradouro.Name = "txtEnderecoLogradouro";
            this.txtEnderecoLogradouro.Size = new System.Drawing.Size(267, 32);
            this.txtEnderecoLogradouro.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 443);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "Logradouro";
            // 
            // txtEnderecoNumero
            // 
            this.txtEnderecoNumero.Location = new System.Drawing.Point(314, 466);
            this.txtEnderecoNumero.Name = "txtEnderecoNumero";
            this.txtEnderecoNumero.Size = new System.Drawing.Size(110, 32);
            this.txtEnderecoNumero.TabIndex = 11;
            this.txtEnderecoNumero.Tag = "Obrigatorio";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(314, 443);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 25);
            this.label10.TabIndex = 17;
            this.label10.Text = "Número";
            // 
            // txtEnderecoComplemento
            // 
            this.txtEnderecoComplemento.Location = new System.Drawing.Point(17, 532);
            this.txtEnderecoComplemento.Name = "txtEnderecoComplemento";
            this.txtEnderecoComplemento.Size = new System.Drawing.Size(213, 32);
            this.txtEnderecoComplemento.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 509);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(221, 25);
            this.label11.TabIndex = 19;
            this.label11.Text = "Complemento (opcional)";
            // 
            // txtEnderecoBairro
            // 
            this.txtEnderecoBairro.Enabled = false;
            this.txtEnderecoBairro.Location = new System.Drawing.Point(458, 466);
            this.txtEnderecoBairro.Name = "txtEnderecoBairro";
            this.txtEnderecoBairro.Size = new System.Drawing.Size(188, 32);
            this.txtEnderecoBairro.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(458, 443);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 25);
            this.label12.TabIndex = 21;
            this.label12.Text = "Bairro";
            // 
            // txtEnderecoMunicipio
            // 
            this.txtEnderecoMunicipio.Enabled = false;
            this.txtEnderecoMunicipio.Location = new System.Drawing.Point(254, 532);
            this.txtEnderecoMunicipio.Name = "txtEnderecoMunicipio";
            this.txtEnderecoMunicipio.Size = new System.Drawing.Size(233, 32);
            this.txtEnderecoMunicipio.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(254, 509);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 25);
            this.label13.TabIndex = 23;
            this.label13.Text = "Municipio";
            // 
            // txtEnderecoUf
            // 
            this.txtEnderecoUf.Enabled = false;
            this.txtEnderecoUf.Location = new System.Drawing.Point(497, 532);
            this.txtEnderecoUf.Name = "txtEnderecoUf";
            this.txtEnderecoUf.Size = new System.Drawing.Size(149, 32);
            this.txtEnderecoUf.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(497, 509);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 25);
            this.label14.TabIndex = 25;
            this.label14.Text = "UF";
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Checked = true;
            this.rbMasculino.Location = new System.Drawing.Point(722, 133);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(120, 29);
            this.rbMasculino.TabIndex = 2;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFeminino
            // 
            this.rbFeminino.AutoSize = true;
            this.rbFeminino.Location = new System.Drawing.Point(722, 164);
            this.rbFeminino.Name = "rbFeminino";
            this.rbFeminino.Size = new System.Drawing.Size(110, 29);
            this.rbFeminino.TabIndex = 28;
            this.rbFeminino.Text = "Feminino";
            this.rbFeminino.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(664, 156);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 25);
            this.label15.TabIndex = 29;
            this.label15.Text = "Sexo";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(361, 208);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(134, 25);
            this.label16.TabIndex = 30;
            this.label16.Text = "Nacionalidade";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(514, 208);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(122, 25);
            this.label17.TabIndex = 32;
            this.label17.Text = "Naturalidade";
            // 
            // cmbNacionalidade
            // 
            this.cmbNacionalidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNacionalidade.FormattingEnabled = true;
            this.cmbNacionalidade.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbNacionalidade.Location = new System.Drawing.Point(366, 236);
            this.cmbNacionalidade.Name = "cmbNacionalidade";
            this.cmbNacionalidade.Size = new System.Drawing.Size(121, 33);
            this.cmbNacionalidade.TabIndex = 4;
            this.cmbNacionalidade.Tag = "Obrigatorio";
            // 
            // cmbNaturalidade
            // 
            this.cmbNaturalidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNaturalidade.FormattingEnabled = true;
            this.cmbNaturalidade.Location = new System.Drawing.Point(519, 236);
            this.cmbNaturalidade.Name = "cmbNaturalidade";
            this.cmbNaturalidade.Size = new System.Drawing.Size(121, 33);
            this.cmbNaturalidade.TabIndex = 5;
            this.cmbNaturalidade.Tag = "Obrigatorio";
            // 
            // txtTelefoneContato
            // 
            this.txtTelefoneContato.Location = new System.Drawing.Point(492, 315);
            this.txtTelefoneContato.Mask = "(##)#####-####";
            this.txtTelefoneContato.Name = "txtTelefoneContato";
            this.txtTelefoneContato.Size = new System.Drawing.Size(154, 32);
            this.txtTelefoneContato.TabIndex = 8;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(492, 292);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(152, 25);
            this.label18.TabIndex = 35;
            this.label18.Text = "Telefone contato";
            // 
            // btnPesquisarCep
            // 
            this.btnPesquisarCep.Location = new System.Drawing.Point(164, 397);
            this.btnPesquisarCep.Name = "btnPesquisarCep";
            this.btnPesquisarCep.Size = new System.Drawing.Size(96, 32);
            this.btnPesquisarCep.TabIndex = 37;
            this.btnPesquisarCep.Text = "Pesquisar";
            this.btnPesquisarCep.UseVisualStyleBackColor = true;
            this.btnPesquisarCep.Click += new System.EventHandler(this.btnPesquisarCep_Click);
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(17, 397);
            this.txtCep.Mask = "#####-###";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(141, 32);
            this.txtCep.TabIndex = 9;
            this.txtCep.Tag = "Obrigatorio";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(180)))), ((int)(((byte)(4)))));
            this.btnCadastrar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(133, 584);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(262, 54);
            this.btnCadastrar.TabIndex = 16;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnAtualizarFuncionario
            // 
            this.btnAtualizarFuncionario.BackColor = System.Drawing.Color.Blue;
            this.btnAtualizarFuncionario.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarFuncionario.Location = new System.Drawing.Point(412, 584);
            this.btnAtualizarFuncionario.Name = "btnAtualizarFuncionario";
            this.btnAtualizarFuncionario.Size = new System.Drawing.Size(262, 54);
            this.btnAtualizarFuncionario.TabIndex = 38;
            this.btnAtualizarFuncionario.Text = "ATUALIZAR";
            this.btnAtualizarFuncionario.UseVisualStyleBackColor = false;
            this.btnAtualizarFuncionario.Click += new System.EventHandler(this.btnAtualizarFuncionario_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id";
            // 
            // btnPesquisarIdFuncionario
            // 
            this.btnPesquisarIdFuncionario.Location = new System.Drawing.Point(95, 156);
            this.btnPesquisarIdFuncionario.Name = "btnPesquisarIdFuncionario";
            this.btnPesquisarIdFuncionario.Size = new System.Drawing.Size(136, 32);
            this.btnPesquisarIdFuncionario.TabIndex = 40;
            this.btnPesquisarIdFuncionario.Text = "Pesquisar Id";
            this.btnPesquisarIdFuncionario.UseVisualStyleBackColor = true;
            // 
            // frmCadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 673);
            this.Controls.Add(this.btnPesquisarIdFuncionario);
            this.Controls.Add(this.btnAtualizarFuncionario);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.btnPesquisarCep);
            this.Controls.Add(this.txtTelefoneContato);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.cmbNaturalidade);
            this.Controls.Add(this.cmbNacionalidade);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.rbFeminino);
            this.Controls.Add(this.rbMasculino);
            this.Controls.Add(this.txtEnderecoUf);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtEnderecoMunicipio);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtEnderecoBairro);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtEnderecoComplemento);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtEnderecoNumero);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtEnderecoLogradouro);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDataNascimento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmCadastroFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadastroFuncionario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtDataNascimento;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEnderecoLogradouro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEnderecoNumero;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEnderecoComplemento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEnderecoBairro;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtEnderecoMunicipio;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEnderecoUf;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.RadioButton rbFeminino;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmbNacionalidade;
        private System.Windows.Forms.ComboBox cmbNaturalidade;
        private System.Windows.Forms.MaskedTextBox txtTelefoneContato;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnPesquisarCep;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnAtualizarFuncionario;
        private System.Windows.Forms.Button btnPesquisarIdFuncionario;
        private System.Windows.Forms.Label label2;
    }
}