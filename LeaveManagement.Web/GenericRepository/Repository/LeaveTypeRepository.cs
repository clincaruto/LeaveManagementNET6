using LeaveManagement.Web.Data;
using LeaveManagement.Web.GenericRepository.IRepository;

namespace LeaveManagement.Web.GenericRepository.Repository
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        public LeaveTypeRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
