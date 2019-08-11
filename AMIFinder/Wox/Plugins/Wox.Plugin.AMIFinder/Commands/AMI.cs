using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Threading;
using Wox.Plugin.AMIFinder.Models;

namespace Wox.Plugin.AMIFinder.Commands
{
    internal static class AMI
    {
        internal static List<Result> LoadList(this string profile, string region)
        {
            var file = "LoadAMIList.ps1";
            var workingDirectory = ".\\Plugins\\Wox.Plugin.AMIFinder\\Commands";
            var stringFromOutput = string.Empty;

            var amiImagesList = new List<AMIImage>();

            var resultList = new List<Result>();

            try
            {
                using (var powerShellInstance = PowerShell.Create())
                {
                    powerShellInstance.AddScript($"cd \"{workingDirectory}\"");

                    // execution with PowerShell 5, use pwsh.exe for PowerShell 6 (Core)
                    powerShellInstance.AddScript($"PowerShell -ExecutionPolicy Bypass -File \"{file}\"" + " " + profile + " " + region);

                    var outputCollection = new PSDataCollection<PSObject>();

                    var result = powerShellInstance.BeginInvoke<PSObject, PSObject>(null, outputCollection);

                    while (result.IsCompleted == false)
                    {
                        Thread.Sleep(1000);
                        // time out command?
                    }

                    foreach (PSObject outputItem in outputCollection)
                    {
                        if (outputItem != null)
                            stringFromOutput += outputItem.ToString();
                    }

                    amiImagesList = JsonConvert.DeserializeObject<List<AMIImage>>(stringFromOutput);
                }

                if (amiImagesList.Any())
                    amiImagesList.ForEach(x =>
                                            resultList.Add(
                                                            new Result
                                                            {
                                                                Title = x.Name,
                                                                SubTitle = x.Description + " (Created on " + x.CreationDate + ")",
                                                                IcoPath = "Images/amifinder.png",
                                                                Score = 8
                                                            }));
                return resultList;
            }
            catch (Exception)
            {
                return new List<Result>
                {
                    new Result
                    {
                        Title = "An error has occured during loading of AMIs",
                        SubTitle = $"Please see if you can run \"{file}\" in location \"{workingDirectory}\"",
                        IcoPath = "Images/amifinder.png",
                        Score = 8
                    }
                };
            }
        }
    }
}
