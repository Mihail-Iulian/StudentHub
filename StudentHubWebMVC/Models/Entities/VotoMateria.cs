namespace StudentHubWebMVC.Models.Entities
{
    public class VotoMateria
    {
        public int IDVoto { get; set; }
        public int IDStudente { get; set; }
        public int IDMateria { get; set; }
        public int VotoMateriaValue { get; set; }
        public DateTime DataRegistrazioneVotoMateria { get; set; }

        // Navigation properties
        public Studente studenteCorrelato { get; set; }
        public Materia materiaCorrelata { get; set; }
    }
}
