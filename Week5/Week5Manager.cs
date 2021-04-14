using System;
using SoongSil_University_Csharp.Core;

namespace SoongSil_University_Csharp.Week5 {
    class Week5Manager : WeekManagerBase {
        public Week5Manager() : base(5) { }

        public override void Main() {
            //refTest(); 
            outTest();
        }

        private void refTest() {
            int num = 1;
            Console.WriteLine("ref num : " + num);

            refTestImpl(ref num);
            Console.WriteLine("ref num : " + num);
        }

        private void refTestImpl(ref int num) {
            // ref의 경우 넘겨주는 매개변수 초기화가 반드시 필요
            num = 10;
        }

        private void outTest() {
            int num = 10;
            int result = 5;
            Console.WriteLine("out result : " + result);

            outTestImpl(num, out result);
            Console.WriteLine("out result : " + result);
        }

        private void outTestImpl(int num, out int result) {
            // out의 경우 넘겨주는 매개변수 초기화가 필요 없음
            // out에서는 넘겨주는 매개변수 초기 값을 무시하기 때문
            result = num * num;
        }
    }
}
