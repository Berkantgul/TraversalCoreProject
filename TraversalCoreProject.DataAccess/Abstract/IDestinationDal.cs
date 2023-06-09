﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalCoreProject.Entity.Concrete;
using TraversalCoreProject.Entity.Dtos;

namespace TraversalCoreProject.DataAccess.Abstract
{
    public interface IDestinationDal : IGenericDal<Destination>
    {
        TraversalStatisticDto StatisticCount();
    }
}
