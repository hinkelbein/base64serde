#CMD
C:\dev\base64serde>dotnet base64decode.dll < base64.txt | dotnet base64encode.dll > base64.out

#PS
PS C:\dev\base64serde> gc .\base64.txt| .\base64decode.exe|.\base64encode.exe > .\base64.out