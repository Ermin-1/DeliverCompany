namespace DeliverCompany.Models
{
    public class Event
    {
        public int EventID { get; set; }

        public DateTime NoteDate { get; set; }
        public string NoteDescription { get; set; }
        public decimal BeloppIn { get; set; }
        public decimal BeloppUt { get; set; }

        // Relation till förare
        public int DriverID { get; set; }
        public Driver? Driver { get; set; }
    }


}

