#!/bin/bash
# Docker commands for ToDo Web API

echo "ToDo Web API Docker Commands"
echo "============================"
echo ""

# Build the Docker image
echo "Building Docker image..."
docker build -t todowebapi:latest .

# Run the container
echo "Running container..."
docker run -d -p 8080:8080 --name todowebapi-container todowebapi:latest

echo "Container started successfully!"
echo "API is available at: http://localhost:8080"
echo "Swagger UI is available at: http://localhost:8080"
echo ""
echo "To stop the container: docker stop todowebapi-container"
echo "To remove the container: docker rm todowebapi-container"
echo "To view logs: docker logs todowebapi-container"