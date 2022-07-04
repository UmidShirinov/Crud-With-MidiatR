using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITS.POP.Domain.Model
{
    public class Companies
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public int CountOfWorker { get; set; }
        public bool Status { get; set; }
    }
}
