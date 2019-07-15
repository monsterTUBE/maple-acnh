using System;
using System.Windows.Forms;

namespace Discord_Webhook_Bomber
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Bomber());
        }
    }
}
