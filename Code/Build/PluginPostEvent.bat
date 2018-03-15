@echo off
set CompileType=%1
set SourceDir=%2
set SourcePluginFileName=%3
set BatPath=%~dp0
set ReleaseTargetDir=%BatPath%..\..\Release\VLEngine\
set ProjectTargetDir=%BatPath%..\..\Project\Assets\Plugins\VLEngine\
set SourcePluginFilePath=%SourceDir%%SourcePluginFileName%
set ReleaseTargetPluginFilePath=%ReleaseTargetDir%%SourcePluginFileName%
set ProjectTargetPluginFilePath=%ProjectTargetDir%%SourcePluginFileName%

echo f | xcopy /y "%SourcePluginFilePath%.dll" "%ReleaseTargetPluginFilePath%.dll" 
echo f | xcopy /y "%SourcePluginFilePath%.dll" "%ProjectTargetPluginFilePath%.dll" 
