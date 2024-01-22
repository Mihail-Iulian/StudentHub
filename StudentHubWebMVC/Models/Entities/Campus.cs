namespace StudentHubWebMVC.Models.Entities
{
    public class Campus
    {
        public int IDCampus { get; set; }
        public string NomeCampus { get; set; }
        public string Localita { get; set; }

        // Navigation properties
        public ICollection<Studente> studenti { get; set; }
    }

}
