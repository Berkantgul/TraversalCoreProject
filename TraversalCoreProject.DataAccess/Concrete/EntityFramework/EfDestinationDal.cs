using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalCoreProject.DataAccess.Abstract;
using TraversalCoreProject.DataAccess.Repository;
using TraversalCoreProject.Entity.Concrete;

namespace TraversalCoreProject.DataAccess.Concrete.EntityFramework
{
	public class EfDestinationDal : GenericRepository<Destination>, IDestinationDal
	{
	}
}
