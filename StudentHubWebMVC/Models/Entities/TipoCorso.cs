namespace StudentHubWebMVC.Models.Entities
{
    public class TipoCorso
    {
        public int IDTipoDiLaurea { get; set; }
        public string TipoDiLaureaNome { get; set; }

        // Navigation properties
        public ICollection<Corso> corso { get; set; }
    }

}
