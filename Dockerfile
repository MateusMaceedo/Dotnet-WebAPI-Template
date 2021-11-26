FROM microsoft/aspnetcore-build:3.1 AS build-env
WORKDIR /app

# Copiar csproj e restaurar dependencias
COPY *.csproj ./
RUN dotnet restore

# Build da aplicacao
COPY . ./
RUN dotnet publish -c Release -o out

# Build da imagem
FROM microsoft/aspnetcore:3.1
WORKDIR /app
COPY --from=build-env /app/out .
