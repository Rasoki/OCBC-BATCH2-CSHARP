#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["PaymentWithJWT2/PaymentWithJWT2.csproj", "PaymentWithJWT2/"]
RUN dotnet restore "PaymentWithJWT2/PaymentWithJWT2.csproj"
COPY . .
WORKDIR "/src/PaymentWithJWT2"
RUN dotnet build "PaymentWithJWT2.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PaymentWithJWT2.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PaymentWithJWT2.dll"]