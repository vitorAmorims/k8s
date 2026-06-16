FROM mcr.microsoft.com/dotnet/sdk:6.0-alpine AS build
WORKDIR /.src
COPY . .
RUN dotnet publish "simples.csproj" -c Release -o /published /p:UseAppHost=false

FROM mcr.microsoft.com/dotnet/aspnet:6.0-alpine
WORKDIR /app
COPY --from=build /published .
ENTRYPOINT [ "dotnet", "simples.dll" ]