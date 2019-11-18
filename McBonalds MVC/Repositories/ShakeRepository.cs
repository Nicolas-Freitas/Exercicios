using System.IO;
using McBonalds_MVC.Models;
using System.Collections.Generic;
namespace McBonalds_MVC.Repositories
{
    public class ShakeRepository
    {
        private const string PATH = "Database/Shake.csv";

        public ShakeRepository()
        {
            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }
        public double ObterPrecoDe(string nomeShake)
        {
            var lista = ObterTodos();
            double preco = 0.0;
            foreach (var item in lista)
            {
                if(item.Nome.Equals(nomeShake))
                {
                    preco = item.Preco;
                    break;
                }
            }
            return preco;
        }
        public List<Shake> ObterTodos()
        {
            List<Shake> shakes = new List<Shake>();
            var linhas = File.ReadAllLines(PATH);

            foreach (var linha in linhas)
            {
                Shake s = new Shake();
                string[] dados = linha.Split(";");
                s.Nome = dados [0];
                s.Preco = double.Parse (dados[1]);
                shakes.Add(s);
            }
            return shakes;
        }
    }
}