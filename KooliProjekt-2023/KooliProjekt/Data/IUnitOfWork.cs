using KooliProjekt.Data.Repositories;

namespace KooliProjekt.Data
{
    public interface IUnitOfWork
    {
        public IProjectRepository ProjectRepository { get; }
        //rember
    }
}