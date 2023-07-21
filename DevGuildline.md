## Setup local database instruction
1. Install Docker on Linux or WSL
2. Make sure you stop your local SQL Server database service
2. Download image and build container
```bash
  docker pull mcr.microsoft.com/azure-sql-edge
  docker run --cap-add SYS_PTRACE -e 'ACCEPT_EULA=1' -e 'MSSQL_SA_PASSWORD=TicketBooking.database.v1' -p 1433:1433 --name azuresql -d mcr.microsoft.com/azure-sql-edge
```
3. Check if the container is running
```bash
  docker ps -a
```
4. From now, if you want to start database service, run
```bash
  docker start azuresql
```
> To stop run
```bash
  docker stop azuresql
```
5. To connect to container using any database management app, 
  - username: SA
  - password: TicketBooking.database.v1