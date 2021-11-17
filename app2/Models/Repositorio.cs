namespace app2.Models
{
    public class Repositorio
    {
        private static List<RespostaConvidados> LISTA = new List<RespostaConvidados>();

        public static void AdicionarResposta(RespostaConvidados resposta)
        {
            LISTA.Add(resposta);
        }

        public static IEnumerable<RespostaConvidados> ListaFinal
        {
            get { return LISTA; }
        }
    }
}
