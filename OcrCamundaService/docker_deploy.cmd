docker rm -f ocr_camunda_service
docker rmi -f ocr_camunda_service
docker build -t ocr_camunda_service .
docker run -p 5656:80 -e ASPNETCORE_ENVIRONMENT=Development -d --name ocr_camunda_service ocr_camunda_service