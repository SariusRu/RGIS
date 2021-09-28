FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["RGIS.GeoTIFF.Console/RGIS.GeoTIFF.Console.csproj", "RGIS.GeoTIFF.Console/"]
RUN dotnet restore "RGIS.GeoTIFF.Console/RGIS.GeoTIFF.Console.csproj"
COPY . .
WORKDIR "/src/RGIS.GeoTIFF.Console"
RUN dotnet build "RGIS.GeoTIFF.Console.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RGIS.GeoTIFF.Console.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RGIS.GeoTIFF.Console.dll"]
