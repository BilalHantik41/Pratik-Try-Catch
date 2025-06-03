using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik___Try_Catch
{
    public class MyOverflowException : OverflowException
    {
        public MyOverflowException(string message) : base(message)
        {
           
        }
    }
}
