docker build -t php-hello-world .
docker ps -a
pause

docker run -ti -p 8080:80 php-hello-world

pause