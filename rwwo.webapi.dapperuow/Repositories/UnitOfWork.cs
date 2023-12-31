using rwwo.webapi.dapperuow.Interfaces;

namespace rwwo.webapi.dapperuow.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public IBrand Brands { get; set; }

        public UnitOfWork(IBrand Brands)
        {
            this.Brands = Brands;
        }
    }
}
