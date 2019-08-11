##PLEASE NOTE: This script uses Powershell 6 (Core) and need to be installed seperately. Install by running this command in Powershell 5 and below: iex "& { $(irm https://aka.ms/install-powershell.ps1) } -UseMSI" 

##Set-ExecutionPolicy -Scope Process -ExecutionPolicy Bypass -Force

#if(!(Get-PackageProvider -Name NuGet)){
##    Install-PackageProvider -Name Nuget -MinimumVersion 2.8.5.201 -Force
##}

if (!(Get-Module -ListAvailable -Name AWSPowerShell)){
    Install-Module -Name AWSPowerShell -Force
}


if(!(Get-Module -Name AWSPowerShell)){
	Import-Module AWSPowerShell
}

## change to load from store
#Set-AWSCredential -AccessKey AKIAWCAX2MBZFPL3CSNB -SecretKey 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 -StoreAs DemoProfile

Set-AWSCredentials -StoredCredentials DemoProfile

Set-DefaultAWSRegion -Region "ap-southeast-2"

#Get-AWSCredential -ListProfileDetail

#Remove-AWSCredentialProfile -ProfileName DemoProfile -Force



#Initialize-AWSDefaultConfiguration -ProfileName DemoProfile -Region ap-southeast-2


$blah = Get-EC2Image -Owner self

$blah | ConvertTo-Json -depth 100 | Out-File ".\file.json"