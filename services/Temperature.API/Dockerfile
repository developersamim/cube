#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["services/Temperature.API/Temperature.API.csproj", "services/Temperature.API/"]
RUN dotnet restore "services/Temperature.API/Temperature.API.csproj"
COPY . .
WORKDIR "/src/services/Temperature.API"
RUN dotnet build "Temperature.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Temperature.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Temperature.API.dll"]
