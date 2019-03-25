using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lottery
{
    public class Config
    {
        int begin;
        int end;

        public int Begin { get => begin; set => begin = value; }
        public int End { get => end; set => end = value; }
    }
}
