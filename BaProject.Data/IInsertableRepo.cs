using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaProject.Data
{
	public interface IInsertableRepo<T> : IRepository<T> where T : class, IEntity
	{
		T Add(T entity);
		List<T> AddRange(List<T> entities);
	}
}
