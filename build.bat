:: This script builds the project.

@ECHO OFF

SET DEVENV="C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\IDE\devenv.exe"

:: Original NuGet, downloaded from NuGet website, is required to restore dependencies.
:: NuGet executable file built into the MSVS 2022 can not restore this solution.
:: Download link: https://www.nuget.org/downloads
:: Tested with NuGet.exe version 6.4.0.123.
SET NUGET="D:\Tools\NuGet\nuget.exe"

SET SOLUTION="MEh Typewriter.sln"
SET FONT_FILE="ext\Fonts\MEh_v2.0.ttf"
SET FONT_INSTALLER="ext\Fonts\Installer\FontInstaller.exe"

SET BIN_SUBFOLDER=MEh Typewriter\bin\Release
SET OUTPUT_FOLDER=_build_

:: 1 ::
ECHO Restoring external sources ...
%NUGET% restore %SOLUTION%

:: 2 ::
ECHO Building ...

%DEVENV% %SOLUTION% /Rebuild Debug
%DEVENV% %SOLUTION% /Rebuild Release

:: 3 ::
ECHO Copying ...

MKDIR %OUTPUT_FOLDER%
COPY /V "%BIN_SUBFOLDER%\MEh Typewriter.exe" "%OUTPUT_FOLDER%"
COPY /V "%BIN_SUBFOLDER%\INIFileParser.dll" "%OUTPUT_FOLDER%"
COPY /V "%BIN_SUBFOLDER%\settings.ini" "%OUTPUT_FOLDER%"

MKDIR "%OUTPUT_FOLDER%\Fonts"
COPY /V %FONT_FILE% "%OUTPUT_FOLDER%\Fonts"

MKDIR "%OUTPUT_FOLDER%\Fonts\Installer"
COPY /V %FONT_INSTALLER% "%OUTPUT_FOLDER%\Fonts\Installer"

ECHO Done
