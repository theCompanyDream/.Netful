#!/bin/bash

dotnet dev-certs https --clean
dotnet dev-certs https -t
dotnet watch run -p .Net.Web/.Net.Web.csproj --urls=https://+:5001