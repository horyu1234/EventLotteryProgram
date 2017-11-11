using System.Collections.Generic;

namespace EventLotteryProgram
{
    public struct Prize
    {
        public string Supporter { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public List<People> To { get; set; }
    }
}