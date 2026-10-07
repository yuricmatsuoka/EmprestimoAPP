using System;
using System.Drawing;
using System.Windows.Forms;

namespace EmprestimoAPP
{
    public partial class EmprestimoAPP : Form
    {
        private EmprestimoDB db;

        public EmprestimoAPP()
        {
            InitializeComponent();
            db = new EmprestimoDB();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        // Botão abre a tela de cadastro
        private void btnNovo_Click(object sender, EventArgs e)
        {
            using (FormNovoEmprestimo form = new FormNovoEmprestimo())
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    CarregarGrid();
                }
            }
        }

        // Botão marca como Devolvido
        private void btnDevolver_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show(
                    "Selecione um item na lista primeiro.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            try
            {
                int id = Convert.ToInt32(
                    dataGridView1.CurrentRow.Cells["Id"].Value
                );

                string status = dataGridView1.CurrentRow
                    .Cells["Status"]
                    .Value?
                    .ToString();

                // Verifica se foi devolvido
                if (status == "Devolvido")
                {
                    MessageBox.Show(
                        "Este item já foi devolvido!",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    return;
                }

                // Marca como devolvido e salva a data
                db.MarcarComoDevolvido(id);

                MessageBox.Show(
                    "Item marcado como devolvido com sucesso!",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                CarregarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Carrega os dados no DataGridView
        private void CarregarGrid()
        {
            if (this.DesignMode)
                return;

            try
            {
                dataGridView1.DataSource = db.GetEmprestimos();
                dataGridView1.ClearSelection();

                if (dataGridView1.Columns.Count > 0)
                {
                    if (dataGridView1.Columns.Contains("Id"))
                        dataGridView1.Columns["Id"].Visible = false;

                    if (dataGridView1.Columns.Contains("Item"))
                        dataGridView1.Columns["Item"].HeaderText = "Item emprestado";

                    if (dataGridView1.Columns.Contains("Amigo"))
                        dataGridView1.Columns["Amigo"].HeaderText = "Nome";

                    if (dataGridView1.Columns.Contains("Contato"))
                        dataGridView1.Columns["Contato"].HeaderText = "Contato";

                    if (dataGridView1.Columns.Contains("DataEmprestimo"))
                        dataGridView1.Columns["DataEmprestimo"].HeaderText = "Data do empréstimo";

                    if (dataGridView1.Columns.Contains("DataDevolucao"))
                        dataGridView1.Columns["DataDevolucao"].HeaderText = "Data de devolução";

                    if (dataGridView1.Columns.Contains("DataRetorno"))
                        dataGridView1.Columns["DataRetorno"].HeaderText = "Data de retorno";

                    if (dataGridView1.Columns.Contains("Status"))
                        dataGridView1.Columns["Status"].HeaderText = "Status";

                    foreach (string col in new[] { "DataEmprestimo", "DataDevolucao", "DataRetorno" })
                    {
                        if (dataGridView1.Columns.Contains(col))
                            dataGridView1.Columns[col].DefaultCellStyle.Format = "dd/MM/yyyy";
                    }

                    dataGridView1.ReadOnly = true;
                    dataGridView1.AllowUserToAddRows = false;
                    dataGridView1.MultiSelect = false;
                    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                    dataGridView1.DefaultCellStyle.SelectionBackColor = Color.White;
                    dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;

                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Destaca os atrasados e devolvidos
        private void dataGridView1_CellFormatting(
            object sender,
            DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            string status = row.Cells["Status"].Value?.ToString();

            object valorDataDevolucao = row.Cells["DataDevolucao"].Value;

            // Item emprestado
            if (status == "Emprestado" &&
                valorDataDevolucao != null &&
                valorDataDevolucao != DBNull.Value)
            {
                DateTime dataCombinada = Convert.ToDateTime(valorDataDevolucao);

                // Passou da data de devolução
                if (dataCombinada < DateTime.Now.Date)
                {
                    row.DefaultCellStyle.BackColor = Color.LightCoral;
                    row.DefaultCellStyle.ForeColor = Color.Black;

                    row.DefaultCellStyle.SelectionBackColor = Color.LightCoral;
                    row.DefaultCellStyle.SelectionForeColor = Color.Black;

                    if (dataGridView1.Columns[e.ColumnIndex].Name == "Status")
                    {
                        e.Value = "Atrasado";
                        e.FormattingApplied = true;
                    }
                }
            }

            // Item devolvido
            else if (status == "Devolvido")
            {
                row.DefaultCellStyle.BackColor = Color.LightGreen;
                row.DefaultCellStyle.ForeColor = Color.Black;

                row.DefaultCellStyle.SelectionBackColor = Color.LightGreen;
                row.DefaultCellStyle.SelectionForeColor = Color.Black;
            }
        }
    }
}