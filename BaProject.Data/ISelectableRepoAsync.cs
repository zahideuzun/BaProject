using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaProject.Data
{
	public interface ISelectableRepoAsync<T> : IRepository<T> where T : class, IEntity
	{
		Task<List<T>> GetAllAsync();

		Task<T> GetByIdAsync(object id);
	}
}
