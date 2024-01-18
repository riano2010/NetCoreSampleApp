REM docker network create ocr-service-network
REM docker network connect ocr-service-network camunda
REM docker network connect ocr-service-network ocr_camunda_service
docker network inspect ocr-service-network

REM curl http://host.docker.internal:5656/swagger/index.html