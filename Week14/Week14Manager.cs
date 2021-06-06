using System;
using System.Threading;
using SoongSil_University_Csharp.Core;

namespace SoongSil_University_Csharp.Week14 {
    class Week14Manager : WeekManagerBase {
        private int resource = 0;

        public Week14Manager() : base(2) { }

        public override void Main() {
            ThreadTest();
        }

        private void ThreadTest() {
            var thread = new Thread(Thread1);
            thread.Start();

            var thread2 = new Thread(Thread2);
            thread2.Start();

            thread.Join();
            thread2.Join();
        }

        private void Thread1() {
            for (int i = 0; i < 5; i++) {
                Console.WriteLine(i + resource);
            }
        }

        private void Thread2() {
            resource += 100;
        }
    }
}
