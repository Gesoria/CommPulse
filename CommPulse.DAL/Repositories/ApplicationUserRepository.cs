using CommPulse.DAL.Entities;

namespace CommPulse.DAL.Repositories
{
    public class ApplicationUserRepository
    {
        private readonly MyDbContext _context;
        public ApplicationUserRepository(MyDbContext context) 
        {
            _context = context; 
        }

        public void AddUser(ApplicationUser user)
        {

        }
    }
}
