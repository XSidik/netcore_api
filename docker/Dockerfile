# Use the official .NET Core runtime as a parent image
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

# Use the SDK image to build the app
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src

# Copy only the project file to leverage Docker cache for dependencies
COPY ["FirstAPI/FirstAPI.csproj", "./FirstAPI/"]
WORKDIR /src/FirstAPI
RUN dotnet restore

# Copy the entire source code
COPY . .

# Build the project
RUN dotnet build -c Release -o /app/build

# Publish the project
FROM build AS publish
RUN dotnet publish -c Release -o /app/publish

# Use runtime image for final output
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FirstAPI.dll"]
