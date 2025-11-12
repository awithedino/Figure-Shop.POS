FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
USER $APP_UID
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["FigureShop.POS/FigureShop.POS.csproj", "FigureShop.POS/"]
RUN dotnet restore "FigureShop.POS/FigureShop.POS.csproj"
COPY . .
WORKDIR "/src/FigureShop.POS"
RUN dotnet build "./FigureShop.POS.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./FigureShop.POS.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FigureShop.POS.dll"]
