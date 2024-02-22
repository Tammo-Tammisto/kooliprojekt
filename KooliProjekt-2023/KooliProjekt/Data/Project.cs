namespace KooliProjekt.Data
{
    public class Project
    {
        public string Id { get; set; }
        public string ProjectName { get; set; }
        public DateTime Start { get; set; }
        public DateTime Deadline { get; set; }
        public decimal Budget { get; set; }
        public decimal HourlyRate { get; set; }
        public string Team { get; set; }
    }
}
