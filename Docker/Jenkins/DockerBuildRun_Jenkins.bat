docker build -t jenkins_docker .

docker ps -a

docker run -p 8080:8080 -v /var/run/docker.sock:/var/run/docker.sock jenkins_docker

pause