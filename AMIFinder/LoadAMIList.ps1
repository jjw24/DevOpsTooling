Para{
    string profileName
    string awsRegion
}

if(!Get-Module Setup-Environment.pms1){
    Import-Module Setup-Environment.pms1
}

Set-AWSCredentials -StoredCredentials profileName

Set-DefaultAWSRegion -Region awsRegion


$blah = Get-EC2Image -Owner self

$blah | ConvertTo-Json -depth 100 | Out-File ".\file.json"