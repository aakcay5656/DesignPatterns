using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatters.Behavioral.Strategy.GoodSoluition
{
    class CompressorMOV : ICompressors
    {
        public void Compress()
        {
            Console.WriteLine("Compressing video using MOV");
        }
    }
}
