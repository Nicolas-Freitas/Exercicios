using System;
using System.IO;
using McBonalds_MVC.Models;

namespace McBonalds_MVC.Repositories 
{
    public class ClienteRepository 
    {
        private const string PATH = "Database/Cliente.csv";
        public ClienteRepository () 
        {
            {
            if (!File.Exists (PATH)) 
                File.Create (PATH).Close ();
            }
        }
        public bool Inserir (Cliente cliente) 
        {
            var linha = new string[] { PreparaRegistroCSV (cliente) };
            File.AppendAllLines (PATH, linha);
            return true;
        }
        public Cliente ObterPor(string email)
        {
            var linhas = File.ReadAllLines(PATH);
            foreach (var linha in linhas)
            {
                if (ExtrairValorDoCampo("email", linha).Equals(email))
                {
                    Cliente c = new Cliente();
                    c.Nome = ExtrairValorDoCampo("nome", linha);
                    c.Email = ExtrairValorDoCampo("email", linha);
                    c.Senha = ExtrairValorDoCampo("senha", linha);
                    c.Endereco = ExtrairValorDoCampo("endereco", linha);
                    c.Telefone = ExtrairValorDoCampo("telefone", linha);
                    c.DataNascimento = DateTime.Parse(ExtrairValorDoCampo("data_nascimento", linha));

                    return c;
                }
            }
            return null;
        }
        private string PreparaRegistroCSV (Cliente cliente) 
        {
            return $"nome={cliente.Nome};email={cliente.Email};senha={cliente.Senha};endereco={cliente.Endereco};telefone={cliente.Telefone};data_nascimento={cliente.DataNascimento}";
        }

        public string ExtrairValorDoCampo(string nomeCampo, string linha)
        {
            var chave = nomeCampo;
            var indiceChave = linha.IndexOf(chave);  

            var indiceTerminal = linha.IndexOf(";", indiceChave);
            var valor = "";

            if(indiceTerminal != -1)
            {
                valor = linha.Substring(indiceChave, indiceTerminal - indiceChave);
            }
            else
            {
                valor = linha.Substring(indiceChave);
            }

            System.Console.WriteLine($"Campo {nomeCampo} tem valor {valor}");
            return valor.Replace(nomeCampo + "=", "");
        }
    }
}