nuget restore
msbuild -t:pack /p:Configuration=Release
PAUSE