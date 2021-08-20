FROM mcr.microsoft.com/dotnet/sdk:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
COPY *.csproj ./
RUN ls
RUN dotnet restore .Net.Web/.Net.Web.csproj

COPY . .
RUN dotnet publish ./.Net.Web -c Release -o out

FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .


ENTRYPOINT ["dotnet", "WorkerService.dll"]