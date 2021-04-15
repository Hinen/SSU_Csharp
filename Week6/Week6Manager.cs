using SoongSil_University_Csharp.Core;
using InternalTest;

namespace SoongSil_University_Csharp.Week6 {
    class Week6Manager : WeekManagerBase {
        public Week6Manager() : base(6) { }

        public override void Main() {
            InternalTest();
        }

        private void InternalTest() {
            var test1 = new InternalTestClass();

            /*
             * can not access,
             * can access only public 
             */
            //test1.TestInternalFunc(); 
            test1.PublicTestFunc();

            var test3 = new ProtectedInternalTestClass();
            test3.testFunction();
        }
    }

    class ProtectedInternalTestClass : InternalTestClass {
        public void testFunction() {
            // can access protected internal only in class
            TestProtectedInternalFunc();
        }
    }
}