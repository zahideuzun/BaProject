using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaProject.Data
{
	public interface IUpdatableRepo<T> : IRepository<T> where T : class, IEntity
	{
		void Update(T entity);
	}
}
