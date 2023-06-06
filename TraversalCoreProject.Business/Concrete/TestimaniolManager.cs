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
	public class TestimaniolManager : ITestimaniolService
	{
		private readonly ITestimaniolDal _testimaniolDal;

        public TestimaniolManager(ITestimaniolDal testimaniolDal)
        {
            _testimaniolDal = testimaniolDal;
        }

        public void Add(Testimaniol entity)
		{
			throw new NotImplementedException();
		}

		public void Delete(Testimaniol entity)
		{
			throw new NotImplementedException();
		}

		public Testimaniol GetById(int id)
		{
			throw new NotImplementedException();
		}

		public List<Testimaniol> GetList()
		{
			return _testimaniolDal.GetList();
		}

		public void Update(Testimaniol entity)
		{
			throw new NotImplementedException();
		}
	}
}
