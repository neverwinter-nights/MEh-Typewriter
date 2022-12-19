:: This script clears temporary files.

@ECHO OFF

SET SOLUTION_FOLDER=MEh Typewriter

ECHO Clearing temporary files ...
RMDIR "%SOLUTION_FOLDER%\bin" /S /Q
RMDIR "%SOLUTION_FOLDER%\obj" /S /Q
RMDIR "packages" /S /Q
