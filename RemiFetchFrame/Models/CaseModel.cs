using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemiFetchFrame.Models
{
    public class CaseModel
    {
        public string CaseName { get; set; }
        public int MatterNumber { get; set; }
        public string SaveLocation { get; set; }
        public DateTime CreatedDate { get; set; }
        public int TotalDevices { get; set; }

    }
}

