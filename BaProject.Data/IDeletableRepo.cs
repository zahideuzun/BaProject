using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaProject.Data
{
	public interface IDeletableRepo<T> : IRepository<T> where T : class, IEntity
	{
		void Delete(T entity);
	}
}
