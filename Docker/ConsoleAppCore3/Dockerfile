FROM mcr.microsoft.com/dotnet/core/sdk:3.1 as build
WORKDIR /app/ConsoleApp/src

#Copy project files
COPY /ConsoleApp .

#Build/publish app to sdk image
RUN dotnet publish -c release -o /app/ConsoleApp/Output/Publish

#Use core runtime image for published artefact
FROM mcr.microsoft.com/dotnet/core/runtime:3.1 as final
WORKDIR /app/ConsoleApp
COPY --from=build /app/ConsoleApp/Output/Publish .

WORKDIR /app/ConsoleApp