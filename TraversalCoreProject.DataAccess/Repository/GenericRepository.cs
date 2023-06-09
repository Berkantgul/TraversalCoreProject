using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TraversalCoreProject.DataAccess.Abstract;
using TraversalCoreProject.DataAccess.Concrete;

namespace TraversalCoreProject.DataAccess.Repository
{
	public class GenericRepository<T> : IGenericDal<T> where T : class 
	{
		public void Add(T entity)
		{
			using (var context = new Context())
			{
				context.Set<T>().Add(entity);
				context.SaveChanges();
			}
		}

		public void Delete(T entity)
		{
			using (var context = new Context())
			{
				context.Set<T>().Remove(entity);
				context.SaveChanges();
			}
		}

		public T GetById(int id)
		{
			using (var context = new Context())
			{
				return context.Set<T>().Find(id);
			}
		}

		public List<T> GetList()
		{
			using (var context = new Context())
			{
				return context.Set<T>().ToList();
			}
		}

        public List<T> GetListByFilter(Expression<Func<T, bool>> filter)
        {
            using (var context = new Context())
            {
                return context.Set<T>().Where(filter).ToList();
            }
        }

        public void Update(T entity)
		{
			using (var context = new Context())
			{
				context.Set<T>().Update(entity);
				context.SaveChanges();
			}
		}
	}
}
