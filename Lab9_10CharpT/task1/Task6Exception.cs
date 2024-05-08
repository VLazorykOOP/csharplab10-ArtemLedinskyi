using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_10CharpT.Task1
{
    public class Task6Exception:Exception
    {
        public Task6Exception() : base() { }
        public Task6Exception(string message) : base(message) { }
        public Task6Exception(string message, Exception innerException) : base(message, innerException) { }
    }
}
