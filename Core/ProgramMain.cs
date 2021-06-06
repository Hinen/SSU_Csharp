namespace SoongSil_University_Csharp.Core {
    class ProgramMain {
        static void Main(string[] args) {
            WeekManagerBase weekManager;

            //weekManager = new Week2.Week2Manager();
            //weekManager = new Week3.Week3Manager();
            //weekManager = new Week5.Week5Manager();
            //weekManager = new Week6.Week6Manager();
            weekManager = new Week14.Week14Manager();

            weekManager.Main();
        }
    }
}
