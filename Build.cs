using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Build4Performance
{
    class Build
    {
        private string CPU { get; set; } // processor
        private string GPU { get; set; } // graphics cards
        private string MOBO { get; set; } // motherboard
        private string RAM { get; set; } // operating memory
        private string DISK { get; set; } // hard drive
        private string CHASIS { get; set; } // case
        private string PSU { get; set; } // power supply
        private double PRICE { get; set; } // price

        public Build()
        {
        }

        public Build(string cpu, string gpu, string mobo, string ram, string disk, string chasis, string psu, double price)
        {
            this.CPU = cpu;
            this.GPU = gpu;
            this.MOBO = mobo;
            this.RAM = ram;
            this.DISK = disk;
            this.CHASIS = chasis;
            this.PSU = psu;
            this.PRICE = price;
        }

    }
}
