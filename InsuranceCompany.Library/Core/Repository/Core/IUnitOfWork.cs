using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.Library.Core.Repository.Core
{
    public interface IUnitOfWork : IDisposable
    {
        int Save();
        new void Dispose();

        public IUserRepository UserRepository { get; }
        public IAidPackageRepository AidPackageRepository { get; }
        public IBranchRepository BranchRepository { get; }
        public IAccidentRepository AccidentRepository { get; }
        public IPolicyRepository PolicyRepository { get; }
        public ICarRepository CarRepository { get; }
        public ITowTruckRepository TowTruckRepository { get; }
        public ITowingServiceRepository TowingServiceRepository { get; }

    }
}
