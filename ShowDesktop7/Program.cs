using System;

namespace ShowDesktop7
{
    static class Program
    {
        [STAThread]
        static void Main(string[] entries)
        {
            Type typeShell=null;

        	typeShell = Type.GetTypeFromProgID("Shell.Application");

            var objShell = Activator.CreateInstance(typeShell);

            typeShell.InvokeMember("MinimizeAll", System.Reflection.BindingFlags.InvokeMethod, null, objShell, null);
        }
    }
}
