using System.Collections.Generic;

namespace 허수아비_이벤트_추첨_프로그램
{
    public struct Prize
    {
        public string Supporter { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public List<People> To { get; set; }
    }
}