@echo off
setlocal



set "REPO_URL=https://github.com/OctavioArnaudo/Absolutivo.git"
set "CLONE_DIR=MyProject"
git clone %REPO_DIR% %CLONE_DIR%
if %ERRORLEVEL% NEQ 0 (
    echo.
    echo ERROR: Fallo al clonar el repositorio.
    echo.
    pause
    goto :end
)



git credential reject %REPO_URL%
if %ERRORLEVEL% NEQ 0 (
    echo Advertencia: git credential reject fallo. (Puede que no hubiera credenciales o url incorrecta)
) else (
    echo Credenciales de Git eliminadas para %REPO_URL%.
)



:end
pause
endlocal
