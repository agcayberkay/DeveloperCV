# =========================
# 1) Build Stage
# =========================
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY . .
RUN dotnet restore "./DeveloperCV.csproj"
RUN dotnet publish "./DeveloperCV.csproj" -c Release -o /app/publish

# =========================
# 2) Runtime Stage
# =========================
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .

# Gunicorn benzeri start
ENTRYPOINT ["dotnet", "DeveloperCV.dll"]

# Render otomatik bu portu kullanır
EXPOSE 8080
