using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalCoreProject.Business.Abstract;
using TraversalCoreProject.DataAccess.Abstract;
using TraversalCoreProject.Entity.Concrete;

namespace TraversalCoreProject.Business.Concrete
{
    public class DestinationManager : IDestinationService
    {
        private readonly IDestinationDal _destinationDal;

        public DestinationManager(IDestinationDal destinationDal)
        {
            _destinationDal = destinationDal;
        }

        public void Add(Destination entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Destination entity)
        {
            throw new NotImplementedException();
        }

        public Destination GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Destination> GetList()
        {
            return _destinationDal.GetList();
        }

        public void Update(Destination entity)
        {
            throw new NotImplementedException();
        }
    }
}
