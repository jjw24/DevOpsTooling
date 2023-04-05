# pull and start container with interactive terminal
docker run -it --name python3 --entrypoint=sh python:3.9.5-alpine
docker run -it centos /bin/bash

# start container with the available interactive terminal
docker start -i python3

# container already running, exec into it with shell terminal
docker exec -it python3 sh
