using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Models
{
    internal class NotDone : IUpdateStatus
    {
        public string UpdateStatus(DateTime deadline)
        {
            return "Unfinished";
        }
    }
}