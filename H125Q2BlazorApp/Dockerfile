# Build stage
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

# Copy csproj and restore dependencies
COPY ["H125Q2BlazorApp.csproj", "./"]
RUN dotnet restore "H125Q2BlazorApp.csproj"

# Copy everything else and build
COPY . .
RUN dotnet build "H125Q2BlazorApp.csproj" -c Release -o /app/build

# Publish stage
FROM build AS publish
RUN dotnet publish "H125Q2BlazorApp.csproj" -c Release -o /app/publish

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS final
WORKDIR /app
EXPOSE 8080
ENV ASPNETCORE_URLS=http://+:8080
ENV ASPNETCORE_ENVIRONMENT=Production

COPY --from=publish /app/publish .

ENTRYPOINT ["dotnet", "H125Q2BlazorApp.dll"]

