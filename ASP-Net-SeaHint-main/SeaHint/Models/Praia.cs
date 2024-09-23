namespace SeaHint.Models
{
    public class Praia
    {

        public string nome { get; set; }
        public string descricao { get; set; }
        public string localizacao { get; set; }

        public string mapa { get; set; }

        public string imagemPraia { get; set; }


        public List <Informacao> Curiosidades{ get; set;}



    }
}
