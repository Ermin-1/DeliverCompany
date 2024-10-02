using System.ComponentModel.DataAnnotations;

namespace DeliverCompany.Models
{
    public class Driver
    {
        public int DriverID { get; set; }

        [Required(ErrorMessage = "Förarnamn är obligatoriskt")]
        public string DriverName { get; set; }

        [Required(ErrorMessage = "Bilregistrering är obligatoriskt")]
        public string CarReg { get; set; }

        [Required(ErrorMessage = "Noteringsdatum är obligatoriskt")]
        public DateTime NoteDate { get; set; }

        public string? NoteDescription { get; set; }

        [Required(ErrorMessage = "Ansvarig medarbetare är obligatorisk")]
        public string ResponsibleEmployee { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Belopp Ut måste vara ett positivt tal")]
        public decimal BeloppUt { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Belopp In måste vara ett positivt tal")]
        public decimal BeloppIn { get; set; }

        public decimal TotalBeloppUt { get; set; }

        public decimal TotalBeloppIn { get; set; }

        // Relation till händelser
        public ICollection<Event>? Events { get; set; }
    }
}
