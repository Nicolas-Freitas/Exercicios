using EscolaDeRock.Interfaces;
namespace EscolaDeRock.Models
{
    class ContraBaixo : InstrumentoMusical, IPercussao, IHarmonia
    
    {
        public bool ManterRitmo(){
            System.Console.WriteLine("Matendo ritmo do contra-baixo");
            return true;
        }

        public bool TocarAcordes()
        {
            System.Console.WriteLine("Tocando acordes do contra-baixo");
            return true;
        }
    }
}