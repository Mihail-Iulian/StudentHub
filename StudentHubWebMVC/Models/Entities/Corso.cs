namespace StudentHubWebMVC.Models.Entities
{
    public class Corso
    {
        public int IDCorso { get; set; }
        public string NomeCorso { get; set; }
        public int Durata { get; set; }
        public int CreditiTotaliCorso { get; set; }
        public int IDDipartimento { get; set; }
        public int IDTipoCorso { get; set; }

        // Navigation properties
        public Dipartimento Dipartimento { get; set; }
        public TipoCorso TipoCorso { get; set; }
        public ICollection<Studente> Studenti { get; set; }
    }


}
