FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /app

COPY ./PayMart.Domain.Products/PayMart.Domain.Products.csproj ./PayMart.Domain.Products/
COPY ./PayMart.Infrastructure.Products/PayMart.Infrastructure.Products.csproj ./PayMart.Infrastructure.Products/
COPY ./PayMart.API.Products/PayMart.API.Products.csproj ./PayMart.API.Products/
RUN dotnet restore ./PayMart.API.Products/PayMart.API.Products.csproj

COPY ./PayMart.Domain.Products ./PayMart.Domain.Products/
COPY ./PayMart.Infrastructure.Products ./PayMart.Infrastructure.Products/
COPY ./PayMart.API.Products ./PayMart.API.Products/

WORKDIR /app/PayMart.API.Products
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build-env /app/PayMart.API.Products/out .

EXPOSE 5002

ENTRYPOINT ["dotnet", "PayMart.API.Products.dll"]
