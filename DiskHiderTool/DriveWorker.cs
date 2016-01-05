using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveHiderTool
{
    class DriveWorker
    {
        public String[] GetDrives()
        {
            return Environment.GetLogicalDrives();
        }

        public void HideDrive(String Drive)
        {
            int value = MakeRegistryValue(Drive);
            RegistryWorker registryworker = new RegistryWorker();
            int currentPolicies = registryworker.ReadPolities();
            int modifedPolicies = currentPolicies | value;
            registryworker.WritePolities(modifedPolicies);
        }

        public void RestoreDrive(String Drive)
        {
            int value = MakeRegistryValue(Drive);
            RegistryWorker registryworker = new RegistryWorker();
            int currentPolicies = registryworker.ReadPolities();
            int modifedPolicies = currentPolicies & (~value);
            registryworker.WritePolities(modifedPolicies);

        }

        private int MakeRegistryValue(String Drive)
        {
            Char driveLetter = Drive[0];
            int offSet = driveLetter - 64 - 1;
            int value = (1 << offSet);
            return value;
        }

    }
}
