using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalCoreProject.DataAccess.Abstract;
using TraversalCoreProject.DataAccess.Repository;
using TraversalCoreProject.Entity.Concrete;
using TraversalCoreProject.Entity.Dtos;

namespace TraversalCoreProject.DataAccess.Concrete.EntityFramework
{
    public class EfDestinationDal : GenericRepository<Destination>, IDestinationDal
    {
        public TraversalStatisticDto StatisticCount()
        {
            using (var context = new Context())
            {
                TraversalStatisticDto traversalStatistic = new TraversalStatisticDto
                {
                    DestinationCount = context.Destinations.Count(),
                    GuideCount = context.Guides.Count()
                };
                return traversalStatistic;
            }
        }
    }
}
