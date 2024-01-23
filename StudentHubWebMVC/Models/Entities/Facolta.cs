namespace StudentHubWebMVC.Models.Entities
{
    public class Facolta
    {
        public int IDFacolta { get; set; }
        public string NomeFacolta { get; set; }

        // Navigation properties
        public ICollection<Dipartimento> Dipartimenti { get; set; }
    }


}
