FROM mcr.microsoft.com/dotnet/sdk:5.0 AS base

WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build

COPY . .

RUN dotnet restore .Net.Web/.Net.Web.csproj

RUN dotnet publish .Net.Web/.Net.Web.csproj -c Release -o /app/publish

FROM base AS final

WORKDIR /app

COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", ".Net.Web.dll"]