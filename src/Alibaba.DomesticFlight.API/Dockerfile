FROM mcr.microsoft.com/dotnet/sdk:6.0.100-bullseye-slim-amd64 as build

WORKDIR /repo
COPY ["src/Alibaba.DomesticFlight.API/Alibaba.DomesticFlight.API.csproj", "src/Alibaba.DomesticFlight.API/"]

RUN dotnet restore "src/Alibaba.DomesticFlight.API/Alibaba.DomesticFlight.API.csproj"

COPY . .

RUN dotnet publish "src/Alibaba.DomesticFlight.API/Alibaba.DomesticFlight.API.csproj" -c Release -o /app/publish  --no-restore


FROM mcr.microsoft.com/dotnet/aspnet:6.0.0-bullseye-slim-amd64
ENV TZ=Asia/Tehran
WORKDIR /app
EXPOSE 80
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "Alibaba.DomesticFlight.API.dll"]