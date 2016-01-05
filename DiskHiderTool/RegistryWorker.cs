using Microsoft.Win32;
using System;
using System.Security.AccessControl;
using System.Security.Principal;

namespace DriveHiderTool
{
    class RegistryWorker
    {
        private readonly String ExplorerPolitiesRegistryPath = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer";
        private readonly String RegistrySubKey = "NoDrives";

        private RegistryKey OpenExplorerPoliciesKey()
        {
            RegistrySecurity RegistrySecurity = new RegistrySecurity();
            WindowsIdentity WindowsIdentity = System.Security.Principal.WindowsIdentity.GetCurrent();
            RegistryAccessRule AccessRule = new RegistryAccessRule(WindowsIdentity.Name, RegistryRights.FullControl, InheritanceFlags.ObjectInherit | InheritanceFlags.ContainerInherit, PropagationFlags.None, AccessControlType.Allow);
            RegistrySecurity.AddAccessRule(AccessRule);
            RegistrySecurity.SetAccessRuleProtection(false, true);
            RegistryKey RegistryKey = Registry.LocalMachine.OpenSubKey(ExplorerPolitiesRegistryPath, true);
            RegistryKey.SetAccessControl(RegistrySecurity);
            return RegistryKey;

        }

        public int ReadPolities()
        {
            RegistryKey key = OpenExplorerPoliciesKey();
            try
            {
                key.GetValue(RegistrySubKey);
                return (int)key.GetValue(RegistrySubKey);
            }
            catch (NullReferenceException ex)
            {
                return 0;
            }

        }

        public void WritePolities(int polities)
        {
            RegistryKey key = OpenExplorerPoliciesKey();
            key.SetValue(RegistrySubKey, polities);
        }
    }
}
