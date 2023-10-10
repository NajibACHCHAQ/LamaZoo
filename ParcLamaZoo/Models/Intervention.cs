namespace ParcLamaZoo.Models
{
    public class Intervention
    {
        public int Id { get; set; }
        public string Titre { get; set; }
        public string Description { get; set; }
        public int VeterinaireId { get; set; }
        public int SoignantId { get; set; }
        public int AnimalId { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime DateDebutIntervention { get; set; }
        public DateTime DateFinIntervention { get; set; }

    }
}
