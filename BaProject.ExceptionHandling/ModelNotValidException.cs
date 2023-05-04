using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaProject.ExceptionHandling
{
	public class ModelNotValidException : ExceptionBase
	{
		public List<string> ValidationMessages { get;}
		public ModelNotValidException(List<string> validationMessages)
		{
			ValidationMessages = validationMessages;
		}
		public ModelNotValidException(List<string> validationMessages, string msg) : base(msg)
		{
			ValidationMessages = validationMessages;
		}
		public ModelNotValidException(List<string> validationMessages, string msg, Exception innerException) : base(msg, innerException)
		{
			ValidationMessages = validationMessages;
		}
	}
}
