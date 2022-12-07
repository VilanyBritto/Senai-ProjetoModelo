namespace AppModelo.View.Windows.Listas
{
    partial class frmListaFuncionarios
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.gvCarregarListaFuncionario = new System.Windows.Forms.DataGridView();
            this.txtConsultarListaFuncionarioPorCpf = new System.Windows.Forms.TextBox();
            this.txtConsultarListaFuncionarioPorId = new System.Windows.Forms.TextBox();
            this.lblConsultarListaFuncionarioPorCpf = new System.Windows.Forms.Label();
            this.lblConsultarListaFuncionarioPorId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvCarregarListaFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(27, 138);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(244, 35);
            this.btnSalvar.TabIndex = 21;
            this.btnSalvar.Text = "Listar Funcionários";
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // gvCarregarListaFuncionario
            // 
            this.gvCarregarListaFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCarregarListaFuncionario.Location = new System.Drawing.Point(27, 179);
            this.gvCarregarListaFuncionario.Name = "gvCarregarListaFuncionario";
            this.gvCarregarListaFuncionario.RowHeadersWidth = 51;
            this.gvCarregarListaFuncionario.Size = new System.Drawing.Size(727, 192);
            this.gvCarregarListaFuncionario.TabIndex = 20;
            this.gvCarregarListaFuncionario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvCarregarListaFuncionario_CellContentClick);
            // 
            // txtConsultarListaFuncionarioPorCpf
            // 
            this.txtConsultarListaFuncionarioPorCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsultarListaFuncionarioPorCpf.Location = new System.Drawing.Point(27, 81);
            this.txtConsultarListaFuncionarioPorCpf.Name = "txtConsultarListaFuncionarioPorCpf";
            this.txtConsultarListaFuncionarioPorCpf.Size = new System.Drawing.Size(156, 26);
            this.txtConsultarListaFuncionarioPorCpf.TabIndex = 19;
            // 
            // txtConsultarListaFuncionarioPorId
            // 
            this.txtConsultarListaFuncionarioPorId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsultarListaFuncionarioPorId.Location = new System.Drawing.Point(27, 30);
            this.txtConsultarListaFuncionarioPorId.Name = "txtConsultarListaFuncionarioPorId";
            this.txtConsultarListaFuncionarioPorId.Size = new System.Drawing.Size(52, 26);
            this.txtConsultarListaFuncionarioPorId.TabIndex = 18;
            // 
            // lblConsultarListaFuncionarioPorCpf
            // 
            this.lblConsultarListaFuncionarioPorCpf.AutoSize = true;
            this.lblConsultarListaFuncionarioPorCpf.Location = new System.Drawing.Point(28, 65);
            this.lblConsultarListaFuncionarioPorCpf.Name = "lblConsultarListaFuncionarioPorCpf";
            this.lblConsultarListaFuncionarioPorCpf.Size = new System.Drawing.Size(27, 13);
            this.lblConsultarListaFuncionarioPorCpf.TabIndex = 17;
            this.lblConsultarListaFuncionarioPorCpf.Text = "CPF";
            // 
            // lblConsultarListaFuncionarioPorId
            // 
            this.lblConsultarListaFuncionarioPorId.AutoSize = true;
            this.lblConsultarListaFuncionarioPorId.Location = new System.Drawing.Point(28, 14);
            this.lblConsultarListaFuncionarioPorId.Name = "lblConsultarListaFuncionarioPorId";
            this.lblConsultarListaFuncionarioPorId.Size = new System.Drawing.Size(16, 13);
            this.lblConsultarListaFuncionarioPorId.TabIndex = 16;
            this.lblConsultarListaFuncionarioPorId.Text = "Id";
            // 
            // frmListaFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 383);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.gvCarregarListaFuncionario);
            this.Controls.Add(this.txtConsultarListaFuncionarioPorCpf);
            this.Controls.Add(this.txtConsultarListaFuncionarioPorId);
            this.Controls.Add(this.lblConsultarListaFuncionarioPorCpf);
            this.Controls.Add(this.lblConsultarListaFuncionarioPorId);
            this.Name = "frmListaFuncionarios";
            this.Text = "Lista de Funcionários";
            ((System.ComponentModel.ISupportInitialize)(this.gvCarregarListaFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView gvCarregarListaFuncionario;
        private System.Windows.Forms.TextBox txtConsultarListaFuncionarioPorCpf;
        private System.Windows.Forms.TextBox txtConsultarListaFuncionarioPorId;
        private System.Windows.Forms.Label lblConsultarListaFuncionarioPorCpf;
        private System.Windows.Forms.Label lblConsultarListaFuncionarioPorId;
    }
}