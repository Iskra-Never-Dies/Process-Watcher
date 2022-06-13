using System;
using System.Diagnostics;
using System.Threading;

namespace KatoAPI
{
    internal class ProcessWatcher
    {
        internal Process Process = new Process();

        internal delegate void Delegate(Process process);
        internal event Delegate Created;

        internal bool GetProcess()
        {
            Process[] processes = Process.GetProcessesByName("RobloxPlayerBeta"); //process name
            if (processes.Length < 1)
                return false;

            //this shit is slightly autistic, 2lazy to fix
            foreach (var process in processes)
            {
                if (String.IsNullOrWhiteSpace(process.MainWindowTitle))
                    continue;

                Process = process;
                return true;
            }

            return false;
        }

        internal void Auto()
        {
            do
                Thread.Sleep(2000); //lol
            while (!GetProcess());

            Created?.Invoke(Process);

            Process.EnableRaisingEvents = true;
            Process.Exited += (ignore, ignore2) =>
                Auto();
        }
    }
}