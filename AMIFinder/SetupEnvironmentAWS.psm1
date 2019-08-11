Function Setup-EnvironmentAWS{

    ##PLEASE NOTE: This script uses Powershell 6 (Core) and need to be installed seperately. Install by running this command in Powershell 5 and below: iex "& { $(irm https://aka.ms/install-powershell.ps1) } -UseMSI"     

    if(!(Get-PackageProvider -Name NuGet)){
        Install-PackageProvider -Name Nuget -MinimumVersion 2.8.5.201 -Force
    }

    if (!(Get-Module -ListAvailable -Name AWSPowerShell)){
        Install-Module -Name AWSPowerShell -Force
    }
}