namespace EmprestimoAPP
{
    partial class FormNovoEmprestimo
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblItem = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.lblAmigo = new System.Windows.Forms.Label();
            this.txtAmigo = new System.Windows.Forms.TextBox();
            this.lblContato = new System.Windows.Forms.Label();
            this.txtContato = new System.Windows.Forms.TextBox();
            this.lblEmprestimo = new System.Windows.Forms.Label();
            this.dtpEmprestimo = new System.Windows.Forms.DateTimePicker();
            this.lblDevolucao = new System.Windows.Forms.Label();
            this.dtpDevolucao = new System.Windows.Forms.DateTimePicker();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(20, 15);
            this.lblItem.Name = "lblItem";
            this.lblItem.Text = "Item emprestado:";
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(20, 32);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(300, 20);
            this.txtItem.TabIndex = 0;
            // 
            // lblAmigo
            // 
            this.lblAmigo.AutoSize = true;
            this.lblAmigo.Location = new System.Drawing.Point(20, 65);
            this.lblAmigo.Name = "lblAmigo";
            this.lblAmigo.Text = "Nome do amigo:";
            // 
            // txtAmigo
            // 
            this.txtAmigo.Location = new System.Drawing.Point(20, 82);
            this.txtAmigo.Name = "txtAmigo";
            this.txtAmigo.Size = new System.Drawing.Size(300, 20);
            this.txtAmigo.TabIndex = 1;
            // 
            // lblContato
            // 
            this.lblContato.AutoSize = true;
            this.lblContato.Location = new System.Drawing.Point(20, 115);
            this.lblContato.Name = "lblContato";
            this.lblContato.Text = "Contato (telefone ou e-mail):";
            // 
            // txtContato
            // 
            this.txtContato.Location = new System.Drawing.Point(20, 132);
            this.txtContato.Name = "txtContato";
            this.txtContato.Size = new System.Drawing.Size(300, 20);
            this.txtContato.TabIndex = 2;
            // 
            // lblEmprestimo
            // 
            this.lblEmprestimo.AutoSize = true;
            this.lblEmprestimo.Location = new System.Drawing.Point(20, 165);
            this.lblEmprestimo.Name = "lblEmprestimo";
            this.lblEmprestimo.Text = "Data do empréstimo:";
            // 
            // dtpEmprestimo
            // 
            this.dtpEmprestimo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEmprestimo.Location = new System.Drawing.Point(20, 182);
            this.dtpEmprestimo.Name = "dtpEmprestimo";
            this.dtpEmprestimo.Size = new System.Drawing.Size(150, 20);
            this.dtpEmprestimo.TabIndex = 3;
            // 
            // lblDevolucao
            // 
            this.lblDevolucao.AutoSize = true;
            this.lblDevolucao.Location = new System.Drawing.Point(20, 215);
            this.lblDevolucao.Name = "lblDevolucao";
            this.lblDevolucao.Text = "Devolução combinada (opcional):";
            // 
            // dtpDevolucao
            // 
            this.dtpDevolucao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDevolucao.Location = new System.Drawing.Point(20, 232);
            this.dtpDevolucao.Name = "dtpDevolucao";
            this.dtpDevolucao.ShowCheckBox = true;
            this.dtpDevolucao.Size = new System.Drawing.Size(150, 20);
            this.dtpDevolucao.TabIndex = 4;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(130, 275);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(90, 30);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(230, 275);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 30);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FormNovoEmprestimo
            // 
            this.AcceptButton = this.btnSalvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(344, 322);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.lblAmigo);
            this.Controls.Add(this.txtAmigo);
            this.Controls.Add(this.lblContato);
            this.Controls.Add(this.txtContato);
            this.Controls.Add(this.lblEmprestimo);
            this.Controls.Add(this.dtpEmprestimo);
            this.Controls.Add(this.lblDevolucao);
            this.Controls.Add(this.dtpDevolucao);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNovoEmprestimo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Novo empréstimo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label lblAmigo;
        private System.Windows.Forms.TextBox txtAmigo;
        private System.Windows.Forms.Label lblContato;
        private System.Windows.Forms.TextBox txtContato;
        private System.Windows.Forms.Label lblEmprestimo;
        private System.Windows.Forms.DateTimePicker dtpEmprestimo;
        private System.Windows.Forms.Label lblDevolucao;
        private System.Windows.Forms.DateTimePicker dtpDevolucao;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
    }
}