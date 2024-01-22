﻿namespace StudentHubWebMVC.Models.Entities
{
    public class VotoTesi
    {
        public int IDVotoTesi { get; set; }
        public int IDStudente { get; set; }
        public int VotoTesiValue { get; set; }
        public DateTime DataRegistrazioneVotoTesi { get; set; }

        // Navigation properties
        public Studente studenteCorrelato { get; set; }
    }

}
