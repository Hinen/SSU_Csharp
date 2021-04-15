using System;

namespace InternalTest {
    public class InternalTestClass {
        // internal은 같은 어셈블리 내에서 public과 동일함
        internal virtual void TestInternalFunc() {
            Console.WriteLine("Internal Function");
        }

        /*
         * protected internal은 같은 어셈블리 내에서는 internal과 동일
         * 단, 외부 어셈블리에서 해당 클래스를 상속 받아서 사용할 경우엔
         * internal은 여전히 접근이 불가하나, 
         * protected internal은 상속한 해당 클래스 내부에서는 접근이 가능함
        */
        protected internal void TestProtectedInternalFunc() {
            Console.WriteLine("Protected Internal Function");
        }

        public virtual void PublicTestFunc() {
            Console.WriteLine("Public Function");
        }

        protected void ProtectedTestFunc() {
            Console.WriteLine("Protected Function");
        }
    }

    class Program {
        static void Main(string[] args) {
            var test1 = new InternalTestClass();

            test1.TestInternalFunc();
            test1.TestProtectedInternalFunc();
            test1.PublicTestFunc();
            //test1.ProtectedTestFunc();
        }
    }
}
