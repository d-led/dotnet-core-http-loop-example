FROM microsoft/dotnet:2.0-runtime
WORKDIR /app
COPY out ./
ENTRYPOINT ["dotnet", "dotnet-core-http-loop-example.dll"]
