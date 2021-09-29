#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["AuditChecklist_MicroService/AuditChecklist_MicroService.csproj", "AuditChecklist_MicroService/"]
RUN dotnet restore "AuditChecklist_MicroService/AuditChecklist_MicroService.csproj"
COPY . .
WORKDIR "/src/AuditChecklist_MicroService"
RUN dotnet build "AuditChecklist_MicroService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AuditChecklist_MicroService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AuditChecklist_MicroService.dll"]