using Google.Cloud.Firestore;

namespace GerenciadorContatos.Services;
internal class FirestoreConnectionFactory
{
    public FirestoreDb CriarFirestoreConnection(string projectId)
    {
        ConfigurarFirestoreCredentials();
        return FirestoreDb.Create(projectId);
    }

    private void ConfigurarFirestoreCredentials()
    {
        try
        {
            string caminho = AppDomain.CurrentDomain.BaseDirectory + "Services/key.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", caminho);
        }
        catch (Exception ex)
        {
            throw new Exception("Erro ao configurar as credenciais do Firestore.", ex);
        }
    }
}
