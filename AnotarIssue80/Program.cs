using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotarIssue80
{
	using Anotar.Log4Net;

	class Program
	{
		static void Main()
		{
			LogTo.Debug("Hello {0}", "World");
		}
	}
}
