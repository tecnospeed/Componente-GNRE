unit UGNRe;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.StdCtrls, spdGnre, spdGnreType, StrUtils,
  Vcl.ExtCtrls, Vcl.ComCtrls, Winapi.ShellAPI;

type
  TFormGNRe = class(TForm)
    btnEnviarGuia: TButton;
    btnConsultaReciboGuia: TButton;
    btnVisualizarGnre: TButton;
    cbCertificados: TComboBox;
    edtProtocolo: TEdit;
    lblProtocolo: TLabel;
    mmXML: TMemo;
    spdGnre: TspdGnre;
    mmRetorno: TMemo;
    mmTX2Complementar: TMemo;
    lblCertificado: TLabel;
    btnLoadConfig: TButton;
    rgConfig: TRadioGroup;
    btnConfigurarIni: TButton;
    pgXmlDestinatario: TPageControl;
    tsXMLDestinatario: TTabSheet;
    pgcTX2Complementar: TPageControl;
    tsTX2Complementar: TTabSheet;
    pgRetorno: TPageControl;
    tsRetorno: TTabSheet;
    pgcGeral: TPageControl;
    tsMenuPrincipal: TTabSheet;
    lblUF: TLabel;
    edtUF: TEdit;
    pgcImpressao: TPageControl;
    tsImpressao: TTabSheet;
    btnImprimirGuia: TButton;
    btnExportarGnre: TButton;
    btnEditarModeloGuia: TButton;
    OpenDialog: TOpenDialog;
    procedure FormCreate(Sender: TObject);
    procedure btnEnviarGuiaClick(Sender: TObject);
    procedure btnConsultaReciboGuiaClick(Sender: TObject);
    procedure btnVisualizarGnreClick(Sender: TObject);
    procedure btnLoadConfigClick(Sender: TObject);
    procedure btnConfigurarIniClick(Sender: TObject);
    procedure cbCertificadosChange(Sender: TObject);
    procedure btnEditarModeloGuiaClick(Sender: TObject);
    procedure btnImprimirGuiaClick(Sender: TObject);
    procedure btnExportarGnreClick(Sender: TObject);
    procedure ExportarGnreClick(Sender: TObject);
    procedure mmXMLKeyDown(Sender: TObject; var Key: Word; Shift: TShiftState);

  private
    { Private declarations }
    function adicionarTemplateTx2(aString: String): String;
    function criarParametroTx2(aEstado : string): string;
  public
    { Public declarations }
  end;

var
  FormGNRe: TFormGNRe;

implementation

{$R *.dfm}

function TFormGNRe.adicionarTemplateTx2(aString: string): string;
begin
  Result := 'formato=tx2' + #13#10 + 'INCLUIR' + #13#10 + aString + #13#10 + 'SALVAR';
end;

function TFormGNRe.criarParametroTx2(aEstado: string): string;
begin
  case AnsiIndexStr(UpperCase(aEstado), ['PE']) of
    0 :
    begin
       Result := adicionarTemplateTx2('c26_produto=004');
    end
    else
      Result := '';
  end;
end;

procedure TFormGNRe.btnConfigurarIniClick(Sender: TObject);
begin
  ShellExecute(Handle,'open',pChar('gnreconfig.ini'),'',pChar(ExtractFilePath(ParamStr(0))),SW_SHOWMAXIMIZED);
end;

procedure TFormGNRe.btnEditarModeloGuiaClick(Sender: TObject);
begin
  //Passar conteúdo ou caminho do arquivo de retorno da consulta de recibo (*-ret-consrecibo.xml)
  spdGnre.EditarModeloImpressao(mmRetorno.Text, '');
end;

procedure TFormGNRe.btnExportarGnreClick(Sender: TObject);
begin
  spdGnre.ExportarGnre(mmRetorno.Text, '');
end;

procedure TFormGNRe.btnImprimirGuiaClick(Sender: TObject);
begin
  spdGnre.ImprimirGnre(mmRetorno.Text, '');
end;

procedure TFormGNRe.btnLoadConfigClick(Sender: TObject);
begin
  if rgConfig.ItemIndex = 0 then
  begin
     spdGnre.LoadConfig();
  end
  else
  begin
  spdGNRe.NomeCertificado.Text := cbCertificados.Text;
  spdGNRe.Ambiente := akProducao;
  spdGNRe.ArquivoServidoresHom := 'C:\Program Files\TecnoSpeed\Gnre\Arquivos\gnreServidoresHom.ini';
  spdGNRe.ArquivoServidoresProd := 'C:\Program Files\TecnoSpeed\Gnre\Arquivos\gnreServidoresProd.ini';
  spdGNRe.TipoCertificado := ckFile;
  spdGNRe.IgnoreInvalidCertificates := true;
  spdGNRe.DiretorioLog := ExtractFileDir(Application.ExeName) + '\Log';
  spdGNRe.DiretorioLogErro := ExtractFileDir(Application.ExeName) + '\LogErro';
  spdGNRe.DiretorioXmlGnre := ExtractFileDir(Application.ExeName) + '\DiretorioXmlGnre';
  spdGNRe.ConexaoSegura := true;
  spdGNRe.TimeOut := 60000;
  spdGNRe.DiretorioTemplates := 'C:\Program Files\TecnoSpeed\GNRe\Arquivos\Templates\';
  spdGNRe.DiretorioEsquemas := 'C:\Program Files\TecnoSpeed\GNRe\Arquivos\Esquemas\';

  spdGNRe.EmailSettings.ServidorSmtp:='smtp.gmail.com';
  spdGNRe.EmailSettings.EmailRemetente:='teste@gmail.com';
  spdGNRe.EmailSettings.EmailDestinatario:='teste@gmail.com';
  spdGNRe.EmailSettings.Assunto:='Exemplo de envio de GNRe por email';
  spdGNRe.EmailSettings.Mensagem:='O arquivo está anexo.';
  spdGNRe.EmailSettings.Usuario:='teste@gmail.com';
  spdGNRe.EmailSettings.Senha:='SenhaTeste';
  spdGNRe.EmailSettings.Autenticacao:=True;
  spdGNRe.EmailSettings.Porta:=587;
  end;
end;

procedure TFormGNRe.cbCertificadosChange(Sender: TObject);
begin
    spdGNRe.NomeCertificado.Text := cbCertificados.Text;
end;

procedure TFormGNRe.btnConsultaReciboGuiaClick(Sender: TObject);
begin
  mmRetorno.Text := spdGNRe.ConsultaReciboGuia(edtProtocolo.Text, edtUF.Text, '08187168000160');
end;

procedure TFormGNRe.btnEnviarGuiaClick(Sender: TObject);
begin
 mmRetorno.Text := spdGNRe.EnviarGuia(mmXml.Text, mmTx2Complementar.Text);
 edtUF.Text := spdGNRe.ExtrairUFDestinatario(mmXml.Text);
 edtProtocolo.Text := spdGNRe.ExtrairNumeroRecibo(mmretorno.Text);
end;

procedure TFormGNRe.ExportarGnreClick(Sender: TObject);
begin
  spdGnre.ExportarGnre(mmRetorno.Text, '');
end;

procedure TFormGNRe.btnVisualizarGnreClick(Sender: TObject);
begin
  spdGNRe.VisualizarGnre(mmRetorno.Text);
end;

procedure TFormGNRe.FormCreate(Sender: TObject);
var
  tx2Complementar : TStringList;
begin
  spdGnre := TspdGnre.Create(nil);
  spdGnre.ConfigurarSoftwareHouse('08187168000160', '');
  spdGnre.LoadConfig();
  cbCertificados.Text := spdGnre.NomeCertificado.Text;
  spdGNRe.ListarCertificados(cbCertificados.Items);

  tx2Complementar := TStringList.Create;
  tx2Complementar.LoadFromFile(ExtractFilePath(ParamStr(0)) + 'TX2Complementar.tx2');
  mmTX2Complementar.Text := tx2Complementar.Text;
end;

//Permitir CTRL+A
procedure TFormGNRe.mmXMLKeyDown(Sender: TObject; var Key: Word; Shift: TShiftState);
begin
  if (Key = Ord('A')) and (ssCtrl in Shift) then
  begin
    TMemo(Sender).SelectAll;
    Key := 0;
  end;
end;

end.
