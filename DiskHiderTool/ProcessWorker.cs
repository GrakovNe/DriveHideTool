using System;
using System.Diagnostics;

namespace DriveHiderTool
{
    class ProcessWorker
    {
        private static readonly String ExplorerProcessName = "explorer";
        public void RestartExplorerProcess()
        {
            Process explorer = Process.GetProcessesByName(ExplorerProcessName)[0];
            explorer.Kill();
            explorer.WaitForExit();
            try
            {
                explorer = Process.GetProcessesByName(ExplorerProcessName)[0];
            }
            catch (IndexOutOfRangeException ex)
            {
                Process.Start(ExplorerProcessName);
            }
        }
    }
}
