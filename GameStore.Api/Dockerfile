# 1. Use the ASP.NET runtime image for running the app
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
WORKDIR /app
EXPOSE 8080

# 2. Use the .NET SDK image to build the app
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

# Copy everything
COPY . .

# Restore dependencies
RUN dotnet restore "./GameStore.Api/GameStore.Api.csproj"

# Publish the app
RUN dotnet publish "./GameStore.Api/GameStore.Api.csproj" -c Release -o /app/publish

# 3. Final image (only runtime, no SDK)
FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "GameStore.Api.dll"]
