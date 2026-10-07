using System;
using System.Windows.Forms;

namespace EmprestimoAPP
{
    public partial class FormNovoEmprestimo : Form
    {
        private EmprestimoDB db = new EmprestimoDB();

        public FormNovoEmprestimo()
        {
            InitializeComponent();
            dtpEmprestimo.Value = DateTime.Now;
            dtpDevolucao.Checked = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtItem.Text) ||
                string.IsNullOrWhiteSpace(txtAmigo.Text) ||
                string.IsNullOrWhiteSpace(txtContato.Text))
            {
                MessageBox.Show("Item, Amigo e Contato são obrigatórios.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime dataDev = DateTime.MinValue;

            if (dtpDevolucao.Checked)
            {
                dataDev = dtpDevolucao.Value.Date;

                if (dataDev < dtpEmprestimo.Value.Date)
                {
                    MessageBox.Show(
                        "A data de devolução não pode ser antes da data do empréstimo.",
                        "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            try
            {
                Emprestimo novo = new Emprestimo(
                    txtItem.Text.Trim(),
                    txtAmigo.Text.Trim(),
                    txtContato.Text.Trim(),
                    dtpEmprestimo.Value.Date,
                    dataDev,
                    "Emprestado");

                db.IncluirEmprestimo(novo);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro no Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormNovoEmprestimo_Load(object sender, EventArgs e)
        {

        }
    }
}