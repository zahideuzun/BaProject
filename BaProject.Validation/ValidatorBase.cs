using BaProject.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaProject.Validation
{
	public abstract class ValidatorBase<TModel> where TModel : class, IModel
	{
		protected ValidatorBase(TModel model)
		{
			Model = model;
			ValidationMessages = new List<string>();
			IsValid = true;
			OnValidate();
		}

		public bool IsValid { get; protected set; }
		public List<string> ValidationMessages { get; }
		public TModel Model { get;  }

		public abstract void OnValidate();
	}
}
