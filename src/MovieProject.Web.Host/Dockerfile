FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/MovieProject.Web.Host/MovieProject.Web.Host.csproj", "src/MovieProject.Web.Host/"]
COPY ["src/MovieProject.Web.Core/MovieProject.Web.Core.csproj", "src/MovieProject.Web.Core/"]
COPY ["src/MovieProject.Application/MovieProject.Application.csproj", "src/MovieProject.Application/"]
COPY ["src/MovieProject.Core/MovieProject.Core.csproj", "src/MovieProject.Core/"]
COPY ["src/MovieProject.EntityFrameworkCore/MovieProject.EntityFrameworkCore.csproj", "src/MovieProject.EntityFrameworkCore/"]
WORKDIR "/src/src/MovieProject.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/MovieProject.Web.Host", "src/MovieProject.Web.Host"]
COPY ["src/MovieProject.Web.Core", "src/MovieProject.Web.Core"]
COPY ["src/MovieProject.Application", "src/MovieProject.Application"]
COPY ["src/MovieProject.Core", "src/MovieProject.Core"]
COPY ["src/MovieProject.EntityFrameworkCore", "src/MovieProject.EntityFrameworkCore"]
WORKDIR "/src/src/MovieProject.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "MovieProject.Web.Host.dll"]
