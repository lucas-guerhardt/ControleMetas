[Setup]
AppName=ControleMetas
AppVersion=1.0.0
DefaultDirName={pf}\ControleMetas
DefaultGroupName=ControleMetas
OutputDir=.
OutputBaseFilename=ControleMetas_Setup
Compression=lzma2
SolidCompression=yes
ArchitecturesInstallIn64BitMode=x64
PrivilegesRequired=lowest

[Files]
Source: "C:\Users\lucas\source\repos\ControleMetas\publish\ControleMetas.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\lucas\source\repos\ControleMetas\publish\*.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\lucas\source\repos\ControleMetas\publish\*.json"; DestDir: "{app}"; Flags: ignoreversion

[Icons]
Name: "{group}\ControleMetas"; Filename: "{app}\ControleMetas.exe"
Name: "{commondesktop}\ControleMetas"; Filename: "{app}\ControleMetas.exe"

[Code]
procedure CriarArquivoEnv();
var
  EnvFile: string;
  F: TFileStream;
  S: AnsiString;
begin
  EnvFile := ExpandConstant('{app}\.env');
  
  if not FileExists(EnvFile) then
  begin
    F := TFileStream.Create(EnvFile, fmCreate);
    try
      S := 'MYSQL_USER=root' + #13#10 +
           'MYSQL_PASSWORD=1234' + #13#10 +
           'MYSQL_PORT=3306' + #13#10;
      F.WriteBuffer(S[1], Length(S));
    finally
      F.Free;
    end;
  end;
end;

[Run]
Filename: "{app}\ControleMetas.exe"; Description: "Executar ControleMetas"; Flags: nowait postinstall

[UninstallDelete]
Type: filesandordirs; Name: "{app}"