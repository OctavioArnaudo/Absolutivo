@echo off
setlocal



set "REPO_URL=https://github.com/OctavioArnaudo/Absolutivo.git"
set "CLONE_DIR=MyProject"
set "UNITY_EDITOR_PATH=C:\Program Files\Unity\Hub\Editor\6000.0.45f1\Editor\Unity.exe"
git clone %REPO_DIR% %CLONE_DIR%
if %ERRORLEVEL% NEQ 0 (
    echo.
    echo ERROR: Fallo al clonar el repositorio.
    echo.
    pause
    goto :end
)



cd "%CLONE_DIR%"
"%UNITY_EDITOR_PATH%" -projectPath "%CD%"
if %ERRORLEVEL% NEQ 0 (
    echo.
    echo ADVERTENCIA: Fallo al abrir Unity Editor.
    echo.
    rem No es un error critico, seguimos con la limpieza.
) else (
    echo.
    echo Unity Editor iniciado. Por favor, trabaja en tu proyecto.
    echo Cuando termines, guarda y cierra Unity Editor para continuar con la limpieza.
    pause
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
