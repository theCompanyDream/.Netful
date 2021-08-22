FROM mcr.microsoft.com/dotnet/sdk:5.0 AS base
ENV ASPNETCORE_URLS http://+:80

WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build

COPY . .

RUN dotnet restore .Net.Web/.Net.Web.csproj

RUN dotnet publish .Net.Web/.Net.Web.csproj -c Release -o /app/publish

FROM base AS final

WORKDIR /app

COPY --from=build /app/publish .

EXPOSE 80/tcp 5000 5001

ENTRYPOINT ["./scripts/run.sh"]