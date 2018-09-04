using Elra3y.DAL.Repositories.Infrastructure;

namespace Elra3y.BLL.Infrastructure
{
    public abstract class BaseManager
    {
        private IUnitOfWork _unitOfWork;
        public IUnitOfWork UnitOfWork => _unitOfWork ?? (_unitOfWork = new UnitOfWork());
    }
}