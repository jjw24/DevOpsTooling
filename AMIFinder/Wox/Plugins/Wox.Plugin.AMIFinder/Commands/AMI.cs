using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using Wox.Plugin.AMIFinder.Models;

namespace Wox.Plugin.AMIFinder.Commands
{
    internal static class AMI
    {
        internal static List<Result> LoadList(this string profile, string region)
        {
            var file = "LoadAMIList.ps1";
            var workingDirectory = ".\\Plugins\\Wox.Plugin.AMIFinder\\Commands";
            var command = $"PowerShell -ExecutionPolicy Bypass -File \"{file}\"" + " " + profile + " " + region;

            var resultList = new List<Result>();

            try
            {
                var stringFromOutput = command.RunAndReturnOutput(workingDirectory);

                var amiImagesList = JsonConvert.DeserializeObject<List<AMIImage>>(stringFromOutput);

                if (amiImagesList.Any())
                {
                    var amimagesListSorted = amiImagesList.OrderByDescending(x => x.CreationDate).ToList();
                    amimagesListSorted.ForEach(x =>
                        resultList.Add(
                                        new Result
                                        {
                                            Title = x.Name,
                                            SubTitle = $"{x.Description} (Created on { x.CreationDate }, " +
                                                        $"{(DateTime.Today - x.CreationDate.Date).TotalDays} days old)",
                                            IcoPath = "Images/amifinder.png",
                                            Score = 8
                                        }));

                    return resultList;
                }

                resultList.Add(
                                new Result
                                {
                                    Title = "Unable to find any AMIs",
                                    SubTitle = "Please check if your PowerShell environment has AWSPowerShell module"
                                               + " installed and there are AMIs in your AWS region",
                                    IcoPath = "Images/amifinder.png",
                                    Score = 8
                                });

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
