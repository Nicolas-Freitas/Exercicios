using System;
using System.Collections.Generic;
using System.IO;
using McBonalds_MVC.Models;
namespace McBonalds_MVC.Repositories 
{
    public class PedidoRepository 
    {
        private const string PATH = "Database/Pedido.csv";
        public PedidoRepository () 
        {
            if (!File.Exists (PATH)) 
            {
                File.Create (PATH).Close ();
            }
        }
        public bool Inserir (Pedido pedido) {
            var linha = new string[] { PrepararRegistroCSV (pedido) };
            File.AppendAllLines (PATH, linha);
            return true;
        }

        public List<Pedido> ObterTodos () 
        {
            var  linhas = File.ReadAllLines(PATH);
            List<Pedido> pedidos = new List<Pedido>();
            foreach (var linha in linhas)
            {
                Pedido pedido = new Pedido();
                pedido.Cliente.Nome = ExtrairValorDoCampo("nome", linha);
                pedido.Cliente.Endereco = ExtrairValorDoCampo("endereco", linha);
                pedido.Cliente.Telefone = ExtrairValorDoCampo("telefone", linha);
                pedido.Cliente.Email = ExtrairValorDoCampo("email", linha);
                pedido.Hamburguer.Nome = ExtrairValorDoCampo("hamburguer_nome", linha);
                pedido.Hamburguer.Preco = double.Parse(ExtrairValorDoCampo("hamburguer_preco", linha));
                pedido.Shake.Nome = ExtrairValorDoCampo("shake_nome", linha);
                pedido.Shake.Preco = double.Parse(ExtrairValorDoCampo("shake_preco", linha));
                pedido.DataDoPedido = DateTime.Parse(ExtrairValorDoCampo("data_pedido", linha));
                pedido.PrecoTotal = Double.Parse(ExtrairValorDoCampo("preco_total", linha));

                pedidos.Add(pedido);

            }return pedidos;
        }

        public List<Pedido> ObterTodosPorCliente(string email)
        {
            var pedidosTotais = ObterTodos();
            List<Pedido> pedidosCliente = new List<Pedido>();
            foreach (var pedido in pedidosTotais)
            {
                if(pedido.Cliente.Email.Equals(email))
                {
                    pedidosCliente.Add(pedido);
                }
            }
            return pedidosCliente;
        }
        private string PrepararRegistroCSV (Pedido pedido) 
        {
            Cliente cliente = pedido.Cliente;
            Hamburguer hamburguer = pedido.Hamburguer;
            Shake shake = pedido.Shake;
            return $"nome={cliente.Nome};endereco={cliente.Endereco};telefone={cliente.Telefone};email={cliente.Email};hamburguer_nome={hamburguer.Nome};hamburguer_preco={hamburguer.Preco};shake_nome={shake.Nome};shake_preco={shake.Preco};data_pedido={pedido.DataDoPedido};preco_total={pedido.PrecoTotal}";
        }
        public string ExtrairValorDoCampo(string nomeCampo, string linha)
        {
            var chave = nomeCampo;
            var indiceChave = linha.IndexOf(chave);  

            var indiceTerminal = linha.IndexOf(";",indiceChave);
            var valor = " ";

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