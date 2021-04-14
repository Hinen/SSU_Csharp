using System;
using SoongSil_University_Csharp.Core;

namespace SoongSil_University_Csharp.Week5 {
    class Week5Manager : WeekManagerBase {
        public Week5Manager() : base(5) { }

        public override void Main() {
            refTest(); 
        }

        private void refTest() {
            int num = 1;
            Console.WriteLine("ref num : " + num);

            refTestImpl(ref num);
            Console.WriteLine("ref num : " + num);
        }

        private void refTestImpl(ref int num) {
            num = 10;
        }
    }
}
