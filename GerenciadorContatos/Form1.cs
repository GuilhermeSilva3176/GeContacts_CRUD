using GerenciadorContatos.GerenciadorDeContatos;
using GerenciadorContatos.Services;
using Google.Cloud.Firestore;

namespace GerenciadorContatos;
public partial class Form1 : Form
{
    private Contatos _db;

    public Form1()
    {
        InitializeComponent();
        dataGridView1.Columns["tblId"].Visible = false;
    }
    private async void btnVerifConec_Click(object sender, EventArgs e)
    {
        try
        {
            FirestoreConnectionFactory factory = new FirestoreConnectionFactory();
            FirestoreDb bancoDeDados = factory.CriarFirestoreConnection("ga31-69723");
            _db = new Contatos(bancoDeDados);
            lblTesteConexao.Text = "CONECTADO";
            lblTesteConexao.ForeColor = Color.Green;
            await PreencherDataGridView();
        }
        catch (Exception ex)
        {
            lblTesteConexao.Text = "ERRO";
            lblTesteConexao.ForeColor = Color.Red;
            MessageBox.Show($"Erro ao conectar ao Firestore: {ex.Message}");
        }
    }

    private void btnCriar_Click(object sender, EventArgs e)
    {
        if (_db != null)
        {
            string nome = txtNome.Text;
            string telefone = txtTelefone.Text;
            string email = txtEmail.Text;
            _db.CriarContatosAsync(nome, telefone, email);
        }
        else
        {
            MessageBox.Show("Não há conexão com banco de dados");
        }
    }
    private async Task PreencherDataGridView()
    {
        dataGridView1.Rows.Clear();
        if (_db != null)
        {
            DocumentSnapshot[] contatosDocuments = await _db.PegarContatosAsync();

            foreach (var contatoDocument in contatosDocuments)
            {
                if (contatoDocument.Exists)
                {
                    Dictionary<string, object> data = contatoDocument.ToDictionary();
                    dataGridView1.Rows.Add(contatoDocument.Id, data["Nome"], data["Telefone"], data["Email"]);
                }
            }
        }
        else
        {
            MessageBox.Show("Não há conexão com banco de dados");
        }
    }
    private async void btnSalvar_Click(object sender, EventArgs e)
    {
        for (int item = 0; item < dataGridView1.Rows.Count; item++)
        {
            string id = dataGridView1.Rows[item].Cells[0].Value?.ToString() ?? "";
            string nome = dataGridView1.Rows[item].Cells[1].Value?.ToString() ?? "";
            string telefone = dataGridView1.Rows[item].Cells[2].Value?.ToString() ?? "";
            string email = dataGridView1.Rows[item].Cells[3].Value?.ToString() ?? "";

            if (!string.IsNullOrEmpty(id))
            {
                try
                {
                    await _db.AtualizarContatoAsync(id, nome, email, telefone);
                    dataGridView1.Rows[item].Cells[1].Value = nome;
                    dataGridView1.Rows[item].Cells[2].Value = telefone;
                    dataGridView1.Rows[item].Cells[3].Value = email;

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao salvar alterações: {ex.Message}");
                }
            }
        }
        await PreencherDataGridView();
    }

    private async void btnDeletar_Click(object sender, EventArgs e)
    {
        if (dataGridView1.SelectedRows.Count > 0)
        {
            DataGridViewRow linhaSelecionada = dataGridView1.SelectedRows[0];
            string id = linhaSelecionada.Cells[0].Value?.ToString() ?? "";

            if (!string.IsNullOrEmpty(id))
            {
                await _db.DeletarContatoAsync(id);
                await PreencherDataGridView();
            }
        }
    }

    private async void btnRefresh_Click(object sender, EventArgs e)
    {
        await PreencherDataGridView();
    }
}