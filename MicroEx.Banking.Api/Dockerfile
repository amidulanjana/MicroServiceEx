FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["MicroEx.Banking.Api/MicroEx.Banking.Api.csproj", "MicroEx.Banking.Api/"]
RUN dotnet restore "MicroEx.Banking.Api/MicroEx.Banking.Api.csproj"
COPY . .
WORKDIR "/src/MicroEx.Banking.Api"
RUN dotnet build "MicroEx.Banking.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "MicroEx.Banking.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "MicroEx.Banking.Api.dll"]