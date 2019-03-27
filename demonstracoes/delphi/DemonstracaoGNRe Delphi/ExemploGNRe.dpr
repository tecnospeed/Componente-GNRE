program ExemploGNRe;

{$R 'UGNRe.dfm' :TForm(UGNRe)}

uses
  Vcl.Forms,
  UGNRe in 'UGNRe.pas' {FormGNRe};

{$R *.res}

begin
  Application.Initialize;
  Application.MainFormOnTaskbar := True;
  Application.CreateForm(TFormGNRe, FormGNRe);
  Application.Run;
end.
