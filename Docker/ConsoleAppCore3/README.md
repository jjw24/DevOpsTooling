This is a sample console app using .Net Core 3.1

## Running in a Docker container

Windows container:

1. In the ConsoleAppCore3 folder, run `DockerBuildRun_ConsoleApp.bat` and the batch script will take care of the rest including building the image, building the project inside the container and running the container with an interactive session.

2. Once the container is ready, you should already be inside the interactive session and in the correct directory- `C:\app\ConsoleApp`

3. Simply execute `ConsoleApp.exe ` +  your message, e.g. `ConsoleApp.exe how is it going` and you should see the output as "Your message: how is it going".

Linux container:

1. Follow steps 1 and 2 above, then to run the app in linux conainer interactive shell, use `dotnet ConsoleApp.dll how is it going` and you should see the output as "Your message: how is it going".