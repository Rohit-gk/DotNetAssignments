using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCrudUsingGeneric.Models
{
    public class Patient
    {
        public int pid { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public int age { get; set; }

    }
}
