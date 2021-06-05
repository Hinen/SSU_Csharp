using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms {
    static class Program {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //var form = new Week9.Week9Form();
            //var form = new Week10.Week10Form();
            var form = new Week11.Week11Form();

            Application.Run(form);
        }
    }
}
