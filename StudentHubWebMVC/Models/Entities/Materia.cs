namespace StudentHubWebMVC.Models.Entities
{
    public class Materia
    {
        public int IDMateria { get; set; }
        public string NomeMateria { get; set; }
        public string CodiceMateria { get; set; }
        public int NumeroOre { get; set; }
        public int CreditiMateria { get; set; }
        public int IDDipartimento { get; set; }
        public int IDSettoreScientificoDisciplinare { get; set; }
        public int AnnoUniversitario { get; set; }

        // Navigation properties
        public Dipartimento Dipartimento { get; set; }
        public SettoreScientificoDisciplinare SettoreScientificoDisciplinare { get; set; }
        public ICollection<VotoMateria> VotiMateria { get; set; }
    }


}
