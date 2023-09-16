using Google.Cloud.Firestore;

namespace GerenciadorContatos.GerenciadorDeContatos;
internal class Contatos
{
    private FirestoreDb _db;
    private CollectionReference _contatos;

    public Contatos(FirestoreDb db)
    {
        this._db = db ?? throw new ArgumentNullException(nameof(db));
        this._contatos = _db.Collection("contatos");
    }
    private async Task<T> ExecutarComTratamentoDeExcecao<T>(Func<Task<T>> action)
    {
        try
        {
            return await action();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"{ex.Message}");
            throw;
        }
    }

    public async Task<DocumentSnapshot[]> PegarContatosAsync()
    {
        return await ExecutarComTratamentoDeExcecao(async () =>
        {
            QuerySnapshot pesquisa = await _contatos.GetSnapshotAsync();
            return pesquisa.Documents.ToArray();
        });
    }

    public async Task<DocumentReference> CriarContatosAsync(string nome, string email, string telefone)
    {
        return await ExecutarComTratamentoDeExcecao(async () =>
        {
            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(telefone))
            {
                throw new ArgumentException("Nome, Email e Telefone devem ser preenchidos");
            }

            var data = new
            {
                Nome = nome,
                Email = email,
                Telefone = telefone,
            };
            DocumentReference document = await _contatos.AddAsync(data);
            return document;
        });
    }

    public async Task AtualizarContatoAsync(string id, string nome, string email, string telefone)
    {
        try
        {
            DocumentReference usuario = _contatos.Document(id);
            var data = new Dictionary<string, object>
            {
                { "Nome", nome},
                { "Telefone", telefone },
                { "Email", email  },
            };
            await usuario.UpdateAsync(data);
        }
        catch (Exception ex) { MessageBox.Show($"Erro ao atualizar contato: {ex.Message}"); }
    }

    public async Task DeletarContatoAsync(string id)
    {
        try
        {
            DocumentReference usuario = _contatos.Document(id);
            await usuario.DeleteAsync();
        }
        catch (Exception ex) 
        { 
            MessageBox.Show($"Erro ao Deletar contato: {ex.Message}");
        }
    }
}