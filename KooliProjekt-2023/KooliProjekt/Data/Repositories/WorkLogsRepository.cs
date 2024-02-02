namespace KooliProjekt.Data.Repositories
{
    public class WorkLogsRepository : BaseRepository<WorkLogs>, IWorkLogsRepository
    {
        public WorkLogsRepository(ApplicationDbContext context) : base(context) { }
    }
}
