docker build -t php-hello-world .
docker images -a
pause

docker run -ti -p 8080:80 php-hello-world

pause