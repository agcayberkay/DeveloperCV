FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY . .

RUN dotnet restore "DeveloperCV/DeveloperCV.csproj"
RUN dotnet publish "DeveloperCV/DeveloperCV.csproj" -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "DeveloperCV.dll"]

EXPOSE 8080
