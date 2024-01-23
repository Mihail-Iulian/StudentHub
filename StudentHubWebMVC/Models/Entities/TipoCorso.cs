namespace StudentHubWebMVC.Models.Entities
{
    public class TipoCorso
    {
        public int IDTipoCorso { get; set; }
        public string TipoCorsoNome { get; set; }

        // Navigation properties
        public ICollection<Corso> Corsi { get; set; }
    }


}
