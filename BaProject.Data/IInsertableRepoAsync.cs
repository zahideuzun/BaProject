using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaProject.Data
{
	public interface IInsertableRepoAsync<T> : IRepository<T> where T : class, IEntity
	{
		Task AddAsync(T entity);
		Task AddRangeAsync(List<T> entities);
	}
}
