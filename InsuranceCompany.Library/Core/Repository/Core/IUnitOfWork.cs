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
        public IAidPackageRepository PaketPomociRepository { get; }
        public IBranchOfficeRepository FilijalaRepository { get; }
        public IAccidentRepository NesrecaRepository { get; }
        public ISignedPolicyRepository SignedPolicyRepository { get; }
        public ICarRepository CarRepository { get; }

    }
}
