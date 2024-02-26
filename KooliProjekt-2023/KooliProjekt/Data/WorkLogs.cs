namespace KooliProjekt.Data
{
    public class WorkLogs : Entity
    {
        public new int Id { get; set; }

        public DateTime Date { get; set; }

        public decimal TimeCost { get; set; }

        public string Performer { get; set; }

        public string Description { get; set; }
    }
}
