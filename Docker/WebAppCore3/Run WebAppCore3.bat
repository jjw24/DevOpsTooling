@echo off

docker build . -t webappcore3
docker run -it -p 8000:80 webappcore3


REM In production, you will typically start your container with `docker run -d`. This argument starts the container as a service, without any console interaction. You then interact with it through other Docker commands or APIs exposed by the containerized application.

REM use `--rm` when testing, it cleans up container resources that are already there including logs that may have been captured in a container that has either stopped or crashed.
