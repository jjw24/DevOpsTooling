Function Setup-EnvironmentAWS{

    if(!(Get-PackageProvider -Name NuGet)){
        Install-PackageProvider -Name Nuget -MinimumVersion 2.8.5.201 -Force
    }

    if (!(Get-Module -ListAvailable -Name AWSPowerShell)){
        Install-Module -Name AWSPowerShell -Force
    }
}