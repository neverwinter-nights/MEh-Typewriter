:: This script updates dependency NuGet packages.

:: The "dotnet-outdated" tool is required for this operation.
:: Download link: 
:: 		https://github.com/dotnet-outdated/dotnet-outdated
:: Installation command: 
::		dotnet tool install --global dotnet-outdated-tool

@ECHO OFF

ECHO Updating external packages ...
dotnet outdated
