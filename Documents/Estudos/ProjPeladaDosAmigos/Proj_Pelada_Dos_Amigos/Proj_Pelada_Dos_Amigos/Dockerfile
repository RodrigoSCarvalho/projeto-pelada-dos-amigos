#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Proj_Pelada_Dos_Amigos/Proj_Pelada_Dos_Amigos.csproj", "Proj_Pelada_Dos_Amigos/"]
RUN dotnet restore "Proj_Pelada_Dos_Amigos/Proj_Pelada_Dos_Amigos.csproj"
COPY . .
WORKDIR "/src/Proj_Pelada_Dos_Amigos"
RUN dotnet build "Proj_Pelada_Dos_Amigos.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Proj_Pelada_Dos_Amigos.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Proj_Pelada_Dos_Amigos.dll"]