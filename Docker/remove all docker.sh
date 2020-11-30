#!/bin/bash

docker stop $(docker ps -q) &&

docker system prune -f &&
docker container prune -f &&
docker image prune -a -f &&
docker volume prune -f &&
docker network prune -f &&

 read -n1 -r -p "Press any key to continue..." key

# List all containers and their attached images and status
docker ps -a

read -n1 -r -p "Press any key to continue..." key