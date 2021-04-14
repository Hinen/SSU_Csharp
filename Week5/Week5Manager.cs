using System;
using SoongSil_University_Csharp.Core;

namespace SoongSil_University_Csharp.Week5 {
    class Week5Manager : WeekManagerBase {
        public Week5Manager() : base(5) { }

        public override void Main() {
            //RefTest(); 
            //OutTest();
            ClassTest();
        }

        private void RefTest() {
            int num = 1;
            Console.WriteLine("ref num : " + num);

            RefTestImpl(ref num);
            Console.WriteLine("ref num : " + num);
        }

        private void RefTestImpl(ref int num) {
            // ref의 경우 넘겨주는 매개변수 초기화가 반드시 필요
            num = 10;
        }

        private void OutTest() {
            int num = 10;
            int result = 5;
            Console.WriteLine("out result : " + result);

            OutTestImpl(num, out result);
            Console.WriteLine("out result : " + result);
        }

        private void OutTestImpl(int num, out int result) {
            // out의 경우 넘겨주는 매개변수 초기화가 필요 없음
            // out에서는 넘겨주는 매개변수 초기 값을 무시하기 때문
            result = num * num;
        }

        private void ClassTest() {
            var test = new TestClass();
        }
    }

    class TestClass {
        public TestClass() {
            Console.WriteLine("TestClass Created");
        }

        ~TestClass() {
            Console.WriteLine("TestClass Deleted");
        }
    }
}
