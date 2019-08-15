using System.Management.Automation;
using System.Threading;

namespace Wox.Plugin.AMIFinder.Commands
{
    internal static class PsScript
    {
        internal static string RunAndReturnOutput(this string command, string workingDirectory)
        {
            var stringFromOutput = string.Empty;

            using (var powerShellInstance = PowerShell.Create())
            {
                powerShellInstance.AddScript($"cd \"{workingDirectory}\"");

                // execution with PowerShell 5, use pwsh.exe for PowerShell 6 (Core)
                powerShellInstance.AddScript(command);

                var outputCollection = new PSDataCollection<PSObject>();

                var result = powerShellInstance.BeginInvoke<PSObject, PSObject>(null, outputCollection);

                while (result.IsCompleted == false)
                {
                    Thread.Sleep(500);
                    // time out command?
                }

                foreach (PSObject outputItem in outputCollection)
                {
                    if (outputItem != null)
                        stringFromOutput += outputItem.ToString();
                }
            }

            return stringFromOutput;
        }
    }
}
