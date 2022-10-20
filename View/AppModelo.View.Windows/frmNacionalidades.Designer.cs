namespace AppModelo.View.Windows
{
    partial class frmNacionalidades
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.gvNacionalidades = new System.Windows.Forms.DataGridView();
            this.btnSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvNacionalidades)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(39, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 20);
            this.textBox1.TabIndex = 1;
            // 
            // txtId
            // 
            this.txtId.AutoSize = true;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(36, 96);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(64, 13);
            this.txtId.TabIndex = 2;
            this.txtId.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(39, 112);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(227, 20);
            this.txtDescricao.TabIndex = 5;
            // 
            // gvNacionalidades
            // 
            this.gvNacionalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvNacionalidades.Location = new System.Drawing.Point(39, 151);
            this.gvNacionalidades.Name = "gvNacionalidades";
            this.gvNacionalidades.Size = new System.Drawing.Size(338, 150);
            this.gvNacionalidades.TabIndex = 6;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(272, 108);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(90, 23);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frmNacionalidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 450);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.gvNacionalidades);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmNacionalidades";
            this.Text = "frmNacionalidades";
            ((System.ComponentModel.ISupportInitialize)(this.gvNacionalidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtId;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.DataGridView gvNacionalidades;
        private System.Windows.Forms.Button btnSalvar;
    }
}