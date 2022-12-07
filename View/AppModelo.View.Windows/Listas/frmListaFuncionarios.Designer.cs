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
            this.gvCarregarListaFuncionario = new System.Windows.Forms.DataGridView();
            this.txtConsultarListaFuncionarioPorCpf = new System.Windows.Forms.TextBox();
            this.lblConsultarListaFuncionarioPorCpf = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvCarregarListaFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // gvCarregarListaFuncionario
            // 
            this.gvCarregarListaFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCarregarListaFuncionario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gvCarregarListaFuncionario.Location = new System.Drawing.Point(0, 93);
            this.gvCarregarListaFuncionario.Margin = new System.Windows.Forms.Padding(4);
            this.gvCarregarListaFuncionario.Name = "gvCarregarListaFuncionario";
            this.gvCarregarListaFuncionario.RowHeadersWidth = 51;
            this.gvCarregarListaFuncionario.Size = new System.Drawing.Size(1031, 378);
            this.gvCarregarListaFuncionario.TabIndex = 20;
            this.gvCarregarListaFuncionario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvCarregarListaFuncionario_CellDoubleClick);
            this.gvCarregarListaFuncionario.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvCarregarListaFuncionario_CellEnter);
            // 
            // txtConsultarListaFuncionarioPorCpf
            // 
            this.txtConsultarListaFuncionarioPorCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsultarListaFuncionarioPorCpf.Location = new System.Drawing.Point(13, 44);
            this.txtConsultarListaFuncionarioPorCpf.Margin = new System.Windows.Forms.Padding(4);
            this.txtConsultarListaFuncionarioPorCpf.Name = "txtConsultarListaFuncionarioPorCpf";
            this.txtConsultarListaFuncionarioPorCpf.Size = new System.Drawing.Size(1005, 30);
            this.txtConsultarListaFuncionarioPorCpf.TabIndex = 19;
            this.txtConsultarListaFuncionarioPorCpf.TextChanged += new System.EventHandler(this.txtConsultarListaFuncionarioPorCpf_TextChanged);
            // 
            // lblConsultarListaFuncionarioPorCpf
            // 
            this.lblConsultarListaFuncionarioPorCpf.AutoSize = true;
            this.lblConsultarListaFuncionarioPorCpf.Location = new System.Drawing.Point(14, 24);
            this.lblConsultarListaFuncionarioPorCpf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConsultarListaFuncionarioPorCpf.Name = "lblConsultarListaFuncionarioPorCpf";
            this.lblConsultarListaFuncionarioPorCpf.Size = new System.Drawing.Size(33, 16);
            this.lblConsultarListaFuncionarioPorCpf.TabIndex = 17;
            this.lblConsultarListaFuncionarioPorCpf.Text = "CPF";
            // 
            // frmListaFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 471);
            this.Controls.Add(this.gvCarregarListaFuncionario);
            this.Controls.Add(this.txtConsultarListaFuncionarioPorCpf);
            this.Controls.Add(this.lblConsultarListaFuncionarioPorCpf);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmListaFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Funcionários";
            this.Load += new System.EventHandler(this.frmListaFuncionarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvCarregarListaFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gvCarregarListaFuncionario;
        private System.Windows.Forms.TextBox txtConsultarListaFuncionarioPorCpf;
        private System.Windows.Forms.Label lblConsultarListaFuncionarioPorCpf;
    }
}