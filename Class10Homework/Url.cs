using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10
{
    public class Url
    {
        public string Name { get; set; }
        public string Message { get; set; }

        public Url(string name, string message)
        {
            this.Name = name;
            this.Message = message;
        }
    }
}
