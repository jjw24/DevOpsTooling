Param(
    [string] $profileName,
    [string] $awsRegion
)

$Error.Clear()

if(!(Get-Module SetupEnvironmentAWS)){
	Import-Module .\SetupEnvironmentAWS -WarningAction SilentlyContinue
}

Setup-EnvironmentAWS

if(!(Get-Module -Name AWSPowerShell)){
    Import-Module AWSPowerShell -WarningAction SilentlyContinue
}

Set-AWSCredentials -StoredCredentials $profileName

Set-DefaultAWSRegion -Region $awsRegion

ConvertTo-Json -InputObject @(Get-EC2Image -Owner self | Select -Property Name, Description, CreationDate)

if($Error.Count -gt 0){
    $Error | Out-File ".\Logs\PSRuntimeErrors.txt"
}