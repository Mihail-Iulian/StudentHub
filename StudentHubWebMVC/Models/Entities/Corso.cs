namespace StudentHubWebMVC.Models.Entities
{
    public class Corso
    {
        public int IDCorso { get; set; }
        public string NomeCorso { get; set; }
        public int Durata { get; set; }
        public int CreditiTotali { get; set; }
        public int IDDipartimento { get; set; }
        public int IDTipoDiLaurea { get; set; }

        // Navigation properties
        public Dipartimento dipartimentoCorrelato { get; set; }
        public TipoCorso tipoCorsoCorrelato { get; set; }
    }

}
