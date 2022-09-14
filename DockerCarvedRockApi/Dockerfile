#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["DockerCarvedRockApi/DockerCarvedRockApi.csproj", "DockerCarvedRockApi/"]
RUN dotnet restore "DockerCarvedRockApi/DockerCarvedRockApi.csproj"
COPY . .
WORKDIR "/src/DockerCarvedRockApi"
RUN dotnet build "DockerCarvedRockApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DockerCarvedRockApi.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DockerCarvedRockApi.dll"]