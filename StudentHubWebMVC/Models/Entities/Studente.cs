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
        public int IDCorsoDiLaurea { get; set; }
        public string Specializzazione { get; set; }
        public int IDCampus { get; set; }

        // Navigation properties
        public Corso corsoCorrelato { get; set; }
        public Campus campusCorrelato { get; set; }
    }

}
