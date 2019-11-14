using System.IO;
using McBonalds_MVC.Models;

namespace McBonalds_MVC.Repositories 
{
    public class ClienteRepository 
    {
        private const string PATH = "Database/Cliente.csv";
        public ClienteRepository () 
        {
            if (!File.Exists (PATH)) 
            {
                File.Create (PATH).Close ();
            }
        }
        public bool Inserir (Cliente cliente) 
        {
            var linha = new string[] { PreparaRegistroCSV (cliente) };
            File.AppendAllLines (PATH, linha);
            return true;
        }
        private string PreparaRegistroCSV (Cliente cliente) 
        {
            return $"nome={cliente.Nome};email={cliente.Email};senha={cliente.Senha}; endereco={cliente.Endereco}; telefone={cliente.Telefone}; data_nascimento={cliente.DataNascimento}";
        }
    }
}