using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_JagdeepSIngh.Models
{
    public class RandomClass
    {
        public Double Flt { get; set; }
        public int Shift { get; set; }
        public char Letter { get; set; }
        public DateTime Date { get { return DateTime.Now; } }
        public string Text { get; set; }
        public string Message { get; set; }
        public int code { get; set; }
    }
}
