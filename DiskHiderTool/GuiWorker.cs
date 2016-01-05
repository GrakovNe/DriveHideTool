using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DriveHiderTool
{
    class GuiWorker
    {
        DriveWorker driveWorker = new DriveWorker();
        ProcessWorker processWorker = new ProcessWorker();
        public void ShowLogicalDrives(ComboBox comboBox)
        {
            String[] logicalDrives = driveWorker.GetDrives();

            foreach (String drive in logicalDrives)
            {
                comboBox.Items.Add(drive);
            }

            comboBox.Text = logicalDrives[0];
        }

        public void HideDrive(ComboBox comboBox)
        {
            driveWorker.HideDrive(comboBox.Text);
            processWorker.RestartExplorerProcess();
        }

        public void RestoreDrive(ComboBox comboBox)
        {
            driveWorker.RestoreDrive(comboBox.Text);
            processWorker.RestartExplorerProcess();
        }
    }
}
