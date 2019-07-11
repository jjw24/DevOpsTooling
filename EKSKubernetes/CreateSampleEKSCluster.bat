
REM Currently to get it working, need to provide AdministratorAccess to the IAM user. Need to investigate further to scale down the access to specifics.


choco upgrade awscli

choco upgrade eksctl aws-iam-authenticator -y

aws --version

eksctl version

pause

REM eksctl create cluster --name prod --version 1.13 --nodegroup-name standard-workers --node-type t3.medium --nodes 3 --nodes-min 1 --nodes-max 4 --node-ami auto

REM eksctl delete cluster --region=ap-southeast-2 --name prod