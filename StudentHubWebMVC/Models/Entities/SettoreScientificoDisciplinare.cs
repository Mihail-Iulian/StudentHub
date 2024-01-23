namespace StudentHubWebMVC.Models.Entities
{
    public class SettoreScientificoDisciplinare
    {
        public int IDSettoreScientificoDisciplinare { get; set; }
        public string NomeSettoreScientificoDisciplinare { get; set; }
        public string CodiceSettoreScientificoDisciplinare { get; set; }

        // Navigation properties
        public ICollection<Materia> Materie { get; set; }
    }


}
