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
	public class SubAboutManager : ISubAboutService
	{
		private readonly ISubAboutDal _subAboutDal;

        public SubAboutManager(ISubAboutDal subAboutDal)
        {
            _subAboutDal = subAboutDal;
        }

        public void Add(SubAbout entity)
		{
			throw new NotImplementedException();
		}

		public void Delete(SubAbout entity)
		{
			throw new NotImplementedException();
		}

		public SubAbout GetById(int id)
		{
			throw new NotImplementedException();
		}

		public List<SubAbout> GetList()
		{
			return _subAboutDal.GetList();
		}

		public void Update(SubAbout entity)
		{
			throw new NotImplementedException();
		}
	}
}
