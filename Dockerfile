FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /app

# copy csproj and restore as distinct layers
COPY *.sln .
COPY ./src/Tiradentes.DF.Api/Tiradentes.DF.Api.csproj ./src/Tiradentes.DF.Api/
COPY ./src/Tiradentes.DF.Application/Tiradentes.DF.Application.csproj ./src/Tiradentes.DF.Application/
COPY ./src/Tiradentes.DF.CrossCutting.IoC/Tiradentes.DF.CrossCutting.IoC.csproj ./src/Tiradentes.DF.CrossCutting.IoC/
COPY ./src/Tiradentes.DF.Domain/Tiradentes.DF.Domain.csproj ./src/Tiradentes.DF.Domain/
COPY ./src/Tiradentes.DF.Infrastructure/Tiradentes.DF.Infrastructure.csproj ./src/Tiradentes.DF.Infrastructure/
COPY ./src/Tiradentes.DF.Services/Tiradentes.DF.Services.csproj ./src/Tiradentes.DF.Services/
COPY ./Tiradentes.DF.Unit/Tiradentes.DF.Unit.csproj ./Tiradentes.DF.Unit/
RUN dotnet restore

# copy everything else and build app
COPY . ./
WORKDIR /app/src/Tiradentes.DF.Api
RUN dotnet publish -c Release -o publish 

FROM mcr.microsoft.com/dotnet/sdk:5.0
WORKDIR /app
COPY --from=build /app/src/Tiradentes.DF.Api/publish  ./
ENV ASPNETCORE_URLS=http://+:80 
ENTRYPOINT ["dotnet", "Tiradentes.DF.Api.dll"]
