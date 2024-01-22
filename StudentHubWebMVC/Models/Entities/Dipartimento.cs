namespace StudentHubWebMVC.Models.Entities
{
    public class Dipartimento
    {
        public int IDDipartimento { get; set; }
        public string NomeDipartimento { get; set; }
        public int IDFacolta { get; set; }

        // Navigation properties
        public Facolta Facolta { get; set; }
        public ICollection<Corso> corsoCorrelato { get; set; }
    }

}
