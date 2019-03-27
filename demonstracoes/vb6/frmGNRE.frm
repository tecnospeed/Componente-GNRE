VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Object = "{3B7C8863-D78F-101B-B9B5-04021C009402}#1.2#0"; "RICHTX32.OCX"
Begin VB.Form frmGNRE 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Exemplo GNRE"
   ClientHeight    =   10695
   ClientLeft      =   7140
   ClientTop       =   3225
   ClientWidth     =   17070
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   10695
   ScaleWidth      =   17070
   ShowInTaskbar   =   0   'False
   Begin RichTextLib.RichTextBox mmRet 
      Height          =   5175
      Left            =   8040
      TabIndex        =   26
      Top             =   5280
      Width           =   8775
      _ExtentX        =   15478
      _ExtentY        =   9128
      _Version        =   393217
      BackColor       =   -2147483634
      ScrollBars      =   2
      Appearance      =   0
      TextRTF         =   $"frmGNRE.frx":0000
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin RichTextLib.RichTextBox mmTX2 
      Height          =   3375
      Left            =   8040
      TabIndex        =   25
      Top             =   1080
      Width           =   8775
      _ExtentX        =   15478
      _ExtentY        =   5953
      _Version        =   393217
      BackColor       =   -2147483634
      ScrollBars      =   2
      Appearance      =   0
      TextRTF         =   $"frmGNRE.frx":0084
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin RichTextLib.RichTextBox mmXML 
      Height          =   5655
      Left            =   240
      TabIndex        =   24
      Top             =   4800
      Width           =   7335
      _ExtentX        =   12938
      _ExtentY        =   9975
      _Version        =   393217
      BackColor       =   -2147483634
      ScrollBars      =   2
      Appearance      =   0
      TextRTF         =   $"frmGNRE.frx":0108
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin VB.CommandButton btnEditarRTM 
      Caption         =   "Editar RTM"
      Height          =   495
      Left            =   5160
      TabIndex        =   17
      Top             =   3480
      Width           =   2295
   End
   Begin VB.CommandButton btnExportar 
      Caption         =   "Exportar PDF"
      Height          =   495
      Left            =   2760
      TabIndex        =   16
      Top             =   3480
      Width           =   2295
   End
   Begin VB.CommandButton btnImprimir 
      Caption         =   "Imprimir"
      Height          =   495
      Left            =   360
      TabIndex        =   15
      Top             =   3480
      Width           =   2295
   End
   Begin VB.CommandButton btnVisualzarGNRe 
      Caption         =   "Visualzar GNRe"
      Height          =   495
      Left            =   5160
      TabIndex        =   14
      Top             =   1920
      Width           =   2295
   End
   Begin VB.CommandButton btnConsultarRecibo 
      Caption         =   "Consultar Recibo Guia"
      Height          =   495
      Left            =   2760
      TabIndex        =   13
      Top             =   1920
      Width           =   2295
   End
   Begin VB.CommandButton btnEnviarGuia 
      Caption         =   "Enviar Guia"
      Height          =   495
      Left            =   360
      TabIndex        =   12
      Top             =   1920
      Width           =   2295
   End
   Begin VB.CommandButton btnAbrirINI 
      Caption         =   "Configurar Arquivo INI"
      Height          =   495
      Left            =   5160
      TabIndex        =   11
      Top             =   1320
      Width           =   2295
   End
   Begin VB.CommandButton btnLoadConfig 
      Caption         =   "LoadConfig"
      Height          =   495
      Left            =   2760
      TabIndex        =   10
      Top             =   1320
      Width           =   2295
   End
   Begin VB.Frame Frame1 
      Caption         =   "Modo de configuração"
      Height          =   615
      Left            =   360
      TabIndex        =   7
      Top             =   1200
      Width           =   2295
      Begin VB.OptionButton rbFonte 
         Caption         =   "Via Fonte"
         Height          =   315
         Left            =   1080
         TabIndex        =   9
         Top             =   240
         Width           =   1095
      End
      Begin VB.OptionButton rbINI 
         Caption         =   "Via INI"
         Height          =   315
         Left            =   120
         TabIndex        =   8
         Top             =   240
         Value           =   -1  'True
         Width           =   855
      End
   End
   Begin VB.TextBox txtUF 
      Height          =   375
      Left            =   12480
      TabIndex        =   5
      Top             =   120
      Width           =   735
   End
   Begin VB.TextBox txtRecibo 
      Height          =   375
      Left            =   8520
      TabIndex        =   3
      Top             =   120
      Width           =   3375
   End
   Begin VB.ComboBox cbNomeCertificado 
      Height          =   315
      Left            =   1800
      TabIndex        =   1
      Text            =   "Selecione o Certificado"
      Top             =   120
      Width           =   5775
   End
   Begin MSComctlLib.TabStrip tsXML 
      Height          =   6135
      Left            =   120
      TabIndex        =   19
      Top             =   4440
      Width           =   7575
      _ExtentX        =   13361
      _ExtentY        =   10821
      _Version        =   393216
      BeginProperty Tabs {1EFB6598-857C-11D1-B16A-00C0F0283628} 
         NumTabs         =   1
         BeginProperty Tab1 {1EFB659A-857C-11D1-B16A-00C0F0283628} 
            Caption         =   "XML Destinatário"
            ImageVarType    =   2
         EndProperty
      EndProperty
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin MSComctlLib.TabStrip TabStrip1 
      Height          =   3855
      Left            =   7920
      TabIndex        =   20
      Top             =   720
      Width           =   9015
      _ExtentX        =   15901
      _ExtentY        =   6800
      _Version        =   393216
      BeginProperty Tabs {1EFB6598-857C-11D1-B16A-00C0F0283628} 
         NumTabs         =   1
         BeginProperty Tab1 {1EFB659A-857C-11D1-B16A-00C0F0283628} 
            Caption         =   "Parâmetros Complementares (TX2 Complementar)"
            ImageVarType    =   2
         EndProperty
      EndProperty
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin MSComctlLib.TabStrip TabStrip2 
      Height          =   5775
      Left            =   7920
      TabIndex        =   21
      Top             =   4800
      Width           =   9015
      _ExtentX        =   15901
      _ExtentY        =   10186
      _Version        =   393216
      BeginProperty Tabs {1EFB6598-857C-11D1-B16A-00C0F0283628} 
         NumTabs         =   1
         BeginProperty Tab1 {1EFB659A-857C-11D1-B16A-00C0F0283628} 
            Caption         =   "Retorno"
            ImageVarType    =   2
         EndProperty
      EndProperty
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin MSComctlLib.TabStrip TabStrip3 
      Height          =   1575
      Left            =   120
      TabIndex        =   22
      Top             =   2760
      Width           =   7575
      _ExtentX        =   13361
      _ExtentY        =   2778
      _Version        =   393216
      BeginProperty Tabs {1EFB6598-857C-11D1-B16A-00C0F0283628} 
         NumTabs         =   1
         BeginProperty Tab1 {1EFB659A-857C-11D1-B16A-00C0F0283628} 
            Caption         =   "Impressão"
            ImageVarType    =   2
         EndProperty
      EndProperty
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin MSComctlLib.TabStrip TabStrip4 
      Height          =   1935
      Left            =   120
      TabIndex        =   23
      Top             =   720
      Width           =   7575
      _ExtentX        =   13361
      _ExtentY        =   3413
      _Version        =   393216
      BeginProperty Tabs {1EFB6598-857C-11D1-B16A-00C0F0283628} 
         NumTabs         =   1
         BeginProperty Tab1 {1EFB659A-857C-11D1-B16A-00C0F0283628} 
            Caption         =   "Impressão"
            ImageVarType    =   2
         EndProperty
      EndProperty
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin VB.Label lbErro 
      Height          =   375
      Left            =   240
      TabIndex        =   18
      Top             =   10800
      Width           =   15735
   End
   Begin VB.Label lbAmbiente 
      Caption         =   "Ambiente: "
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   13440
      TabIndex        =   6
      Top             =   240
      Width           =   2655
   End
   Begin VB.Label lbUF 
      Caption         =   "UF: "
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   12000
      TabIndex        =   4
      Top             =   240
      Width           =   375
   End
   Begin VB.Label lbRecibo 
      Caption         =   "Recibo: "
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   7800
      TabIndex        =   2
      Top             =   240
      Width           =   735
   End
   Begin VB.Label lbCertificado 
      Caption         =   "Listar Certificados: "
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   120
      TabIndex        =   0
      Top             =   240
      Width           =   1695
   End
End
Attribute VB_Name = "frmGNRE"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
'Declarado Objeto pertencente a Classe que faz interação com servidores da Receita'
Dim GNRE As GnreX.spdGnreX

Private Sub btnAbrirINI_Click()
    Shell "C:\Windows\System32\notepad.exe " + App.Path + "\gnreConfig.ini", vbNormalFocus
End Sub

Private Sub btnConsultarRecibo_Click()

On Error GoTo TrataErro
 
mmRet.Text = GNRE.ConsultaReciboGuia(txtRecibo.Text, txtUF.Text, "08187168000160")

TrataErro:
    If Err.Description <> "" Then
    lbErro = Err.Description
    MsgBox Err.Description
 End If
End Sub

Private Sub btnEditarRTM_Click()

On Error GoTo TrataErro

'Passar conteúdo ou caminho do arquivo de retorno da consulta de recibo (*-ret-consrecibo.xml)
GNRE.EditarModeloImpressao mmRet.Text, "", ""

TrataErro:
    If Err.Description <> "" Then
    lbErro = Err.Description
    MsgBox Err.Description
End If

End Sub

Private Sub btnEnviarGuia_Click()

On Error GoTo TrataErro

mmRet.Text = GNRE.EnviarGuia(mmXML.Text, mmTX2.Text, "")
txtRecibo.Text = GNRE.ExtrairNumeroRecibo(mmRet.Text)
txtUF.Text = GNRE.ExtrairUFDestinatario(mmXML.Text)

TrataErro:
    If Err.Description <> "" Then
    lbErro = Err.Description
    MsgBox Err.Description
End If

End Sub

Private Sub btnExportar_Click()

On Error GoTo TrataErro

GNRE.ExportarGnre mmRet.Text, "", "", ""

TrataErro:
    If Err.Description <> "" Then
    lbErro = Err.Description
    MsgBox Err.Description
 End If

End Sub

Private Sub btnImprimir_Click()

On Error GoTo TrataErro
 
GNRE.ImprimirGnre mmRet.Text, "", "", ""
 
TrataErro:
    If Err.Description <> "" Then
    lbErro = Err.Description
    MsgBox Err.Description
 End If
 
End Sub

Private Sub btnLoadConfig_Click()

On Error GoTo TrataErro

If rbINI.Value = True Then
    GNRE.LoadConfig App.Path + "\gnreConfig.ini"
    If GNRE.Ambiente = akProducao Then lbAmbiente.Caption = "Ambiente: 1 - Produção" Else lbAmbiente.Caption = "Ambiente: 2 - Homologação"
    cbNomeCertificado.Text = GNRE.NomeCertificado
       
ElseIf rbFonte.Value = True Then
'[GNRE]
    GNRE.Ambiente = akProducao
    GNRE.NomeCertificado = cbNomeCertificado.Text
    GNRE.ArquivoServidoresHom = "C:\Program Files\TecnoSpeed\Gnre\Arquivos\gnreServidoresHom.ini"
    GNRE.ArquivoServidoresProd = "C:\Program Files\TecnoSpeed\Gnre\Arquivos\gnreServidoresProd.ini"
    GNRE.TipoCertificado = ckFile
    GNRE.IgnoreInvalidCertificates = True
    GNRE.DiretorioLog = App.Path & IIf(Right$(App.Path, 1) <> "\", "\", "") & "Log"
    GNRE.DiretorioLogErro = App.Path & IIf(Right$(App.Path, 1) <> "\", "\", "") & "LogErro"
    GNRE.DiretorioXmlGnre = App.Path & IIf(Right$(App.Path, 1) <> "\", "\", "") & "DiretorioXmlGnre"
    GNRE.ConexaoSegura = True
    GNRE.TimeOut = 60000
    GNRE.DiretorioTemplates = "C:\Program Files\TecnoSpeed\GNRe\Arquivos\Templates\"
    GNRE.DiretorioEsquemas = "C:\Program Files\TecnoSpeed\GNRe\Arquivos\Esquemas\"

'[MAIL]
    GNRE.ServidorSmtp = "smtp.gmail.com"
    GNRE.EmailRemetente = "teste@gmail.com"
    GNRE.EmailDestinatario = "teste@gmail.com"
    GNRE.AssuntoEmail = "Exemplo de envio de GNRe por email"
    GNRE.MensagemEmail = "O arquivo está anexo."
    GNRE.UsuarioEmail = "teste@gmail.com"
    GNRE.SenhaEmail = "SenhaTeste"
    GNRE.AutenticacaoEmail = True
    GNRE.PortaEmail = 587
    
    If GNRE.Ambiente = akProducao Then lbAmbiente.Caption = "Ambiente: 1 - Produção" Else lbAmbiente.Caption = "Ambiente: 2 - Homologação"
End If

TrataErro:
    If Err.Description <> "" Then
    lbErro = Err.Description
    MsgBox Err.Description
 End If

End Sub

Private Sub btnVisualzarGNRe_Click()

On Error GoTo TrataErro
    
GNRE.VisualizarGnre mmRet.Text, "", ""
    
TrataErro:
    If Err.Description <> "" Then
    lbErro = Err.Description
    MsgBox Err.Description
 End If
    
End Sub

Private Sub Form_Initialize()

On Error GoTo TrataErro
 
'Instancia o Objeto responsável pela interação com servidores da Receita'
Set GNRE = New GnreX.spdGnreX
    
TrataErro:
    If Err.Description <> "" Then
    lbErro = Err.Description
    MsgBox Err.Description
 End If

End Sub

Private Sub Form_Load()
Dim i As Integer
Dim vetor As Variant

On Error GoTo TrataErro

'Configurar CNPJ da SoftwareHouse
GNRE.ConfigurarSoftwareHouse "08187168000160", ""

'Utiliza Método do Componente para Listar Certificados instalado no SO
vetor = Split(GNRE.ListarCertificados("|"), "|")
cbNomeCertificado.Clear

For i = LBound(vetor) To UBound(vetor) - 1
    cbNomeCertificado.AddItem vetor(i)
Next

TrataErro:
    If Err.Description <> "" Then
    lbErro = Err.Description
    MsgBox Err.Description
End If

End Sub

