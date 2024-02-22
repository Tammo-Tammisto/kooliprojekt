using System.Threading.Tasks;
using KooliProjekt.Models;

namespace KooliProjekt.Data.Repositories
{
    public class TeamMembersRepository : ITeamMembersRepository
    {
        private readonly BaseRepository<TeamMembers> _baseRepository;

        public TeamMembersRepository(ApplicationDbContext context)
        {
            _baseRepository = new BaseRepository<TeamMembers>(context);
        }

        public async Task<PagedResult<TeamMembers>> List(int page, int pageSize)
        {
            return await _baseRepository.List(page, pageSize);
        }

        public async Task<TeamMembers> GetById(int id)
        {
            return await _baseRepository.GetById(id);
        }

        public async Task Save(TeamMembers teamMember)
        {
            await _baseRepository.Save(teamMember);
        }

        public async Task Delete(int id)
        {
            await _baseRepository.Delete(id);
        }
    }
}
