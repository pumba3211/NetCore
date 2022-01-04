#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["MiDietaApi/MiDietaApi.csproj", "MiDietaApi/"]
RUN dotnet restore "MiDietaApi/MiDietaApi.csproj"
COPY . .
WORKDIR "/src/MiDietaApi"
RUN dotnet build "MiDietaApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MiDietaApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MiDietaApi.dll"]