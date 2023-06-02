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
	public class FirstFeatureManager : IFirstFeatureService
	{
		private readonly IFirstFeatureDal _firstFeatureDal;

        public FirstFeatureManager(IFirstFeatureDal firstFeatureDal)
        {
            _firstFeatureDal = firstFeatureDal;
        }

        public void Add(FirstFeature entity)
		{
			throw new NotImplementedException();
		}

		public void Delete(FirstFeature entity)
		{
			throw new NotImplementedException();
		}

		public FirstFeature GetById(int id)
		{
			throw new NotImplementedException();
		}

		public List<FirstFeature> GetList()
		{
			return _firstFeatureDal.GetList();
		}

		public void Update(FirstFeature entity)
		{
			throw new NotImplementedException();
		}
	}
}
