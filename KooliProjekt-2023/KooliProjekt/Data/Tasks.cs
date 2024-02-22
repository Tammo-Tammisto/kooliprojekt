using System;

namespace KooliProjekt.Data
{
    public class Tasks
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public DateTime TaskStart { get; set; }

        public TimeSpan ExpectedTime { get; set; }

        public string InCharge { get; set; }

        public string Description { get; set; }

        public string WorkDone { get; set; }

        public string Files { get; set; }
    }
}
