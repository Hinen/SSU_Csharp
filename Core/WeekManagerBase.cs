using System;

namespace SoongSil_University_Csharp.Core {
    abstract class WeekManagerBase {
        public WeekManagerBase(int week) {
            Console.WriteLine($"Init Week{week}Manager");
        }

        public abstract void Main();
    }
}
