# Use the official .NET SDK image as a build environment
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env

# Set active directory to /app
WORKDIR /app

# Copy the project file
COPY *.csproj ./

# Restore dependencies
RUN dotnet restore

# Copy the remaining files
COPY . ./

# Build the application
RUN dotnet publish -c Release -o out

# Use the official ASP.NET Core runtime image for the final image
FROM mcr.microsoft.com/dotnet/aspnet:6.0

# Set active directory to /app
WORKDIR /app

# Separate build environment from runtime environment
COPY --from=build-env /app/out .

# Expose the port the app will run on (80)
EXPOSE 80

# Command to run the application
ENTRYPOINT ["dotnet", "IceCreamShopContentful.dll"]

