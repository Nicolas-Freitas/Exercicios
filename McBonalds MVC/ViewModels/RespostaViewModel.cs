namespace McBonalds_MVC.ViewModels
{
    public class RespostaViewModel
    {
        public string Mensagem {get;set;}


        public RespostaViewModel()
        {

        }

        public RespostaViewModel (string mensagem)
        {
            this.Mensagem = mensagem;
        }
    }
}