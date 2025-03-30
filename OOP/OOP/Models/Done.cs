using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Models
{
    internal class Done : IUpdateStatus
    {
        public string UpdateStatus(DateTime deadline)
        {
            return "Finished";
        }
    }
}