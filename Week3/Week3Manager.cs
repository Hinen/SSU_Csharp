using System;
using SoongSil_University_Csharp.Core;

namespace SoongSil_University_Csharp.Week3 {
    class Week3Manager : WeekManagerBase {
        public Week3Manager() : base(3) { }

        public override void Main() {
            //ypeChangeTest();
            //ConstTest();
            PrefixPostfix();
        }

        private void TypeChangeTest() {
            int num = 12345;
            string str = "123";

            string numToStr = num.ToString();
            int strToNum = int.Parse(str);

            Console.Out.WriteLine($"num : {num}, {num.GetType()}");
            Console.Out.WriteLine($"str : {str}, {str.GetType()}");
            Console.Out.WriteLine($"numToStr : {numToStr}, {numToStr.GetType()}");
            Console.Out.WriteLine($"strToNum : {strToNum}, {strToNum.GetType()}");
        }

        private void ConstTest() {
            const int num = 1234;
            //num = 2; // const can not fix
        }

        private void PrefixPostfix() {
            int num = 5;
            Console.Out.WriteLine(num); // 5
            Console.Out.WriteLine(num++); // 5
            Console.Out.WriteLine(++num); // 7
        }
    }
}
