namespace SoongSil_University_Csharp.Core {
    class ProgramMain {
        static void Main(string[] args) {
            WeekManagerBase weekManager;

            //weekManager = new Week2.Week2Manager();
            weekManager = new Week3.Week3Manager();

            weekManager.Main();
        }
    }
}
