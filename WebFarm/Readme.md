All commands should be executed from WebFarm directory.

## Start web farm
docker-compose up -d --scale web-app=3 --scale static-content=2 --build

## Set nodes count
docker-compose scale web-app=5

## Shut down web farm
docker-compose down; 

## Urls:
- http://localhost:5000 web app
- http://localhost:9000 haproxy
- http://localhost:8500 consul
