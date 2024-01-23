namespace StudentHubWebMVC.Models.Entities
{
    public class Studente
    {
        public int IDStudente { get; set; }
        public string NomeStudente { get; set; }
        public string CognomeStudente { get; set; }
        public DateTime DataNascita { get; set; }
        public string LuogoNascita { get; set; }
        public string AnnoUniversitario { get; set; }
        public int IDCorso { get; set; }
        public string Specializzazione { get; set; }
        public int IDCampus { get; set; }

        // Navigation properties
        public Corso Corso { get; set; }
        public Campus Campus { get; set; }
        public ICollection<VotoMateria> VotiMateria { get; set; }
        public VotoTesi VotoTesi { get; set; }
    }

}
