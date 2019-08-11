Param(
    [string] $profileName,
    [string] $awsRegion
)

if(!(Get-Module SetupEnvironmentAWS)){
	Import-Module .\SetupEnvironmentAWS
}

Setup-EnvironmentAWS

if(!(Get-Module -Name AWSPowerShell)){
    Import-Module AWSPowerShell
}

Set-AWSCredentials -StoredCredentials $profileName

Set-DefaultAWSRegion -Region $awsRegion


$blah = Get-EC2Image -Owner self

$blah | ConvertTo-Json -depth 100 | Out-File ".\file.json"