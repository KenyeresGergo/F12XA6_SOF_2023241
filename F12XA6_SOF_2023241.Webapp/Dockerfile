#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["F12XA6_SOF_2023241.Webapp/F12XA6_SOF_2023241.Webapp.csproj", "F12XA6_SOF_2023241.Webapp/"]
COPY ["F12XA6_SOF_2023241.Logic/F12XA6_SOF_2023241.Logic.csproj", "F12XA6_SOF_2023241.Logic/"]
COPY ["F12XA6_SOF_2023241.Models/F12XA6_SOF_2023241.Models.csproj", "F12XA6_SOF_2023241.Models/"]
COPY ["F12XA6_SOF_2023241.Repository/F12XA6_SOF_2023241.Repository.csproj", "F12XA6_SOF_2023241.Repository/"]
RUN dotnet restore "F12XA6_SOF_2023241.Webapp/F12XA6_SOF_2023241.Webapp.csproj"
COPY . .
WORKDIR "/src/F12XA6_SOF_2023241.Webapp"
RUN dotnet build "F12XA6_SOF_2023241.Webapp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "F12XA6_SOF_2023241.Webapp.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "F12XA6_SOF_2023241.Webapp.dll"]