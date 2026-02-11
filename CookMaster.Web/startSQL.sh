#!/bin/bash

# Remove any existing container with the same name (optional)
docker rm -f cookmaster-sql 2>/dev/null

# Run SQL Server container with persistence
docker run -d \
--name cookmaster-sql \
-p 1433:1433 \
-v ~/docker-data/sqlserver:/var/opt/mssql \
-e "ACCEPT_EULA=Y" \
-e "SA_PASSWORD=YourStrong!Passw0rd" \
--restart unless-stopped \
cookmaster-sql