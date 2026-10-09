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
            this.grpDados = new System.Windows.Forms.GroupBox();
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
            this.btnSair = new System.Windows.Forms.Button();
            this.grpDados.SuspendLayout();
            this.SuspendLayout();

            // grpDados
            this.grpDados.Controls.Add(this.lblItem);
            this.grpDados.Controls.Add(this.txtItem);
            this.grpDados.Controls.Add(this.lblAmigo);
            this.grpDados.Controls.Add(this.txtAmigo);
            this.grpDados.Controls.Add(this.lblContato);
            this.grpDados.Controls.Add(this.txtContato);
            this.grpDados.Controls.Add(this.lblEmprestimo);
            this.grpDados.Controls.Add(this.dtpEmprestimo);
            this.grpDados.Controls.Add(this.lblDevolucao);
            this.grpDados.Controls.Add(this.dtpDevolucao);
            this.grpDados.Location = new System.Drawing.Point(12, 12);
            this.grpDados.Name = "grpDados";
            this.grpDados.Size = new System.Drawing.Size(330, 280);
            this.grpDados.TabIndex = 0;
            this.grpDados.TabStop = false;
            this.grpDados.Text = "Dados do empréstimo";
         
            // lblItem
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(15, 25);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(87, 13);
            this.lblItem.TabIndex = 0;
            this.lblItem.Text = "Item emprestado:";
       
            // txtItem
            this.txtItem.Location = new System.Drawing.Point(15, 42);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(300, 20);
            this.txtItem.TabIndex = 1;
      
            // lblAmigo
            this.lblAmigo.AutoSize = true;
            this.lblAmigo.Location = new System.Drawing.Point(15, 75);
            this.lblAmigo.Name = "lblAmigo";
            this.lblAmigo.Size = new System.Drawing.Size(84, 13);
            this.lblAmigo.TabIndex = 2;
            this.lblAmigo.Text = "Nome do amigo:";
         
            // txtAmigo
            this.txtAmigo.Location = new System.Drawing.Point(15, 92);
            this.txtAmigo.Name = "txtAmigo";
            this.txtAmigo.Size = new System.Drawing.Size(300, 20);
            this.txtAmigo.TabIndex = 3;
        
            // lblContato
            this.lblContato.AutoSize = true;
            this.lblContato.Location = new System.Drawing.Point(15, 125);
            this.lblContato.Name = "lblContato";
            this.lblContato.Size = new System.Drawing.Size(150, 13);
            this.lblContato.TabIndex = 4;
            this.lblContato.Text = "Contato (telefone ou e-mail):";
           
            // txtContato
            this.txtContato.Location = new System.Drawing.Point(15, 142);
            this.txtContato.Name = "txtContato";
            this.txtContato.Size = new System.Drawing.Size(300, 20);
            this.txtContato.TabIndex = 5;
        
            // lblEmprestimo
            this.lblEmprestimo.AutoSize = true;
            this.lblEmprestimo.Location = new System.Drawing.Point(15, 175);
            this.lblEmprestimo.Name = "lblEmprestimo";
            this.lblEmprestimo.Size = new System.Drawing.Size(106, 13);
            this.lblEmprestimo.TabIndex = 6;
            this.lblEmprestimo.Text = "Data do empréstimo:";
     
            // dtpEmprestimo
            this.dtpEmprestimo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEmprestimo.Location = new System.Drawing.Point(15, 192);
            this.dtpEmprestimo.Name = "dtpEmprestimo";
            this.dtpEmprestimo.Size = new System.Drawing.Size(150, 20);
            this.dtpEmprestimo.TabIndex = 7;
        
            // lblDevolucao
            this.lblDevolucao.AutoSize = true;
            this.lblDevolucao.Location = new System.Drawing.Point(15, 225);
            this.lblDevolucao.Name = "lblDevolucao";
            this.lblDevolucao.Size = new System.Drawing.Size(172, 13);
            this.lblDevolucao.TabIndex = 8;
            this.lblDevolucao.Text = "Devolução combinada (opcional):";
           
            // dtpDevolucao
            this.dtpDevolucao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDevolucao.Location = new System.Drawing.Point(15, 242);
            this.dtpDevolucao.Name = "dtpDevolucao";
            this.dtpDevolucao.ShowCheckBox = true;
            this.dtpDevolucao.Size = new System.Drawing.Size(150, 20);
            this.dtpDevolucao.TabIndex = 9;
           
            // btnSalvar
            this.btnSalvar.Location = new System.Drawing.Point(242, 304);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 30);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
          
            // btnSair
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Location = new System.Drawing.Point(12, 304);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(100, 30);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
          
            // FormNovoEmprestimo
            this.AcceptButton = this.btnSalvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSair;
            this.ClientSize = new System.Drawing.Size(354, 346);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.grpDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNovoEmprestimo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Novo empréstimo";
            this.grpDados.ResumeLayout(false);
            this.grpDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDados;
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
        private System.Windows.Forms.Button btnSair;
    }
}