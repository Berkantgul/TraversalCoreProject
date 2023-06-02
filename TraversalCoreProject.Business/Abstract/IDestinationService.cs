using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalCoreProject.Entity.Concrete;
using TraversalCoreProject.Entity.Dtos;

namespace TraversalCoreProject.Business.Abstract
{
	public interface IDestinationService : IGenericService<Destination>
	{
		TraversalStatisticDto StatisticCount();

    }
}
