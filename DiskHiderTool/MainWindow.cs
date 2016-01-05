using DriveHiderTool;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace DriveHiderTool
{
    public partial class MainWindow : Form
    {

        GuiWorker guiWorker = new GuiWorker();
        DriveWorker driveWorker = new DriveWorker();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void diskHiderToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            guiWorker.ShowLogicalDrives(DrivesList);
        }

        private void HideButton_Click(object sender, EventArgs e)
        {
            guiWorker.HideDrive(DrivesList);
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            guiWorker.RestoreDrive(DrivesList);
        }
    }
}
