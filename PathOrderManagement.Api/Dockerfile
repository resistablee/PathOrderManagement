#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["PathOrderManagement.Api/PathOrderManagement.Api.csproj", "PathOrderManagement.Api/"]
COPY ["PathOrderManagement.Container/PathOrderManagement.Container.csproj", "PathOrderManagement.Container/"]
COPY ["PathOrderManagement.Business/PathOrderManagement.Business.csproj", "PathOrderManagement.Business/"]
COPY ["PathOrderManagement.Common/PathOrderManagement.Common.csproj", "PathOrderManagement.Common/"]
COPY ["PathOrderManagement.Contract/PathOrderManagement.Contract.csproj", "PathOrderManagement.Contract/"]
COPY ["PathOrderManagement.Entity/PathOrderManagement.Entity.csproj", "PathOrderManagement.Entity/"]
COPY ["PathOrderManagement.DataAccess/PathOrderManagement.DataAccess.csproj", "PathOrderManagement.DataAccess/"]
RUN dotnet restore "PathOrderManagement.Api/PathOrderManagement.Api.csproj"
COPY . .
WORKDIR "/src/PathOrderManagement.Api"
RUN dotnet build "PathOrderManagement.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PathOrderManagement.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PathOrderManagement.Api.dll"]