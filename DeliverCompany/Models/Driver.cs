namespace DeliverCompany.Models
{
    public class Driver
    {
        public int DriverID { get; set; }
        public string DriverName { get; set; }
        public string CarReg { get; set; }
        public DateTime NoteDate { get; set; }
        public string NoteDescription { get; set; }
        public string ResponsibleEmployee { get; set; }
        public decimal BeloppUt { get; set; }
        public decimal BeloppIn { get; set; }
        public decimal TotalBeloppUt { get; set; }
        public decimal TotalBeloppIn { get; set; }
    }

}
