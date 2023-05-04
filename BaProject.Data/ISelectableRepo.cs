using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaProject.Data
{
	public interface ISelectableRepo<T> : IRepository<T> where T : class, IEntity
	{
		List<T> GetAll();
		T GetById(object id);
		
		//eger bu solutioni ado.net ya da dapper ile kullanilacaksa bu metot farkli bir interface cikmali.
		List<T> GetBy(Func<T, bool> condition);

	}
}
