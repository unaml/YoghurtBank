#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ProjectApi1/ProjectApi1.csproj", "ProjectApi1/"]
RUN dotnet restore "ProjectApi1/ProjectApi1.csproj"
COPY . .
WORKDIR "/src/ProjectApi1"
RUN dotnet build "ProjectApi1.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ProjectApi1.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ProjectApi1.dll"]