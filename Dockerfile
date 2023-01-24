FROM microsoft/dotnet:6.0-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
#
#
FROM microsoft/dotnet:6.0-sdk AS builder
WORKDIR /source
COPY . .
WORKDIR /CleanArch.Infracture
RUN dotnet build -c Release
WORKDIR /CleanArch
RUN dotnet build -c Release -o /app
#
#
FROM builder AS publish
RUN dotnet publish -c Release -o /app
#
#
FROM base AS production
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "MyWallet.WebApi.dll"]