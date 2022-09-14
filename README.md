# .NET 6 API

## How-to
- Install .NET SDK version 6
- Install Docker Desktop
- Navigate to the root of `DockerCardRockApi` project 
- Run the command `dotnet run`
- If not running as a docker cotainer, you can access on localhost on `https://localhost:<PORT>/swagger/index.html`

## API routes
- `/Products` - `GET` requests only, accepts categories such as `all, kayaks, boots` etc.
- `/QuickOrder` - `POST` requests only, requires 2 arguments:
```
{
  "productId": 0,
  "quantity": 0
}
```