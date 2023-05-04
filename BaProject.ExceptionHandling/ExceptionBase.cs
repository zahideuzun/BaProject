using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaProject.ExceptionHandling
{
	/// <summary>
	/// 
	/// </summary>
	public abstract class ExceptionBase : Exception
	{
		public ExceptionBase()
		{

		}

		public ExceptionBase(string msg) : base(msg)
		{

		}

		public ExceptionBase(string msg, Exception innerException) : base(msg, innerException)
		{

		}
		
	}
}
