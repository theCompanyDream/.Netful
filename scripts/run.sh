#!/bin/bash

dotnet dev-certs https --clean
dotnet dev-certs https -t
dotnet watch run -p Netful.Api/Netful.Api.csproj --urls=https://+:5001