#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["PaymentAPIWithJWT3/PaymentAPIWithJWT3.csproj", "PaymentAPIWithJWT3/"]
RUN dotnet restore "PaymentAPIWithJWT3/PaymentAPIWithJWT3.csproj"
COPY . .
WORKDIR "/src/PaymentAPIWithJWT3"
RUN dotnet build "PaymentAPIWithJWT3.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PaymentAPIWithJWT3.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PaymentAPIWithJWT3.dll"]