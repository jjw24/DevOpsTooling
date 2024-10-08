FOR /f "tokens=*" %%i IN ('docker ps -q') DO docker stop %%i

CALL docker system prune -a --volumes -f

REM Separately
CALL docker container prune -f
CALL docker image prune -a -f
CALL docker volume prune -a -f
CALL docker network prune -f
PAUSE

REM List all containers and their attached images and status
docker ps -a
PAUSE
