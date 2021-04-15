using System;
using SoongSil_University_Csharp.Core;
using InternalTest;

namespace SoongSil_University_Csharp.Week6 {
    class Week6Manager : WeekManagerBase {
        public Week6Manager() : base(6) { }

        public override void Main() {
            //InternalTest();
            PartialClassTest();
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

        private void PartialClassTest() {
            var test = new TestPartialClass();
            test.TestFunc1();
            test.TestFunc2();
        }
    }

    class ProtectedInternalTestClass : InternalTestClass {
        public void testFunction() {
            // can access protected internal only in class
            TestProtectedInternalFunc();
        }
    }

    class TestClass {
        public virtual void TestFunc() {
            Console.WriteLine("TestFunc");
        }
    }

    class SealedTestClass : TestClass {
        public sealed override void TestFunc() {
            Console.WriteLine("SealedTestFunc");
        }
    }

    class NewTestClass : TestClass {
        public new void TestFunc() {
            Console.WriteLine("NewTestFunc");
        }
    }

    class SealedOverrideTestClass : SealedTestClass {
        /*
         * can not override by sealed
        public override void TestFunc() {
        }
        */
    }

    partial class TestPartialClass {
        public void TestFunc1() {
            Console.WriteLine("TestFunc1");
        }
    }

    partial class TestPartialClass {
        public void TestFunc2() {
            Console.WriteLine("TestFunc2");
        }
    }
}