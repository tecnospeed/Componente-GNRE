## [7.1.40.57]

**Correções**

* DSML-1903 - Corrigindo códigos do tipo do documento para o estado de BA.
* DSML-2025 - correção para quando informado campo extras no tx2 complementar e a UF também adiciona automaticamente o mesmo valor, não duplicar

## [7.1.40.53]

**Correções**

- [DSML-1403](https://tecnospeed.atlassian.net/browse/DSML-1403) - Correção dos códigos de Documento de Origem e Receitas Aceitas para as UFs: AC, AM, MT, PA.
- [DSML-1781](https://tecnospeed.atlassian.net/browse/DSML-1781) - Corringindo a geração do XML ao informar o campo c01_UfFavorecida
- [DSML-1601](https://tecnospeed.atlassian.net/browse/DSML-1601) - Disponibilizando os campos de ValorDeAtualizacaoMonetaria e ValorDeCredito no método ExtrairDadosRetorno para o Estado de ES

## [7.1.39.5226]

**Correções**

* DSML-1385 - Ajuste no método de impressão/exportação onde não estava aceitando o parâmetro da aChave.

## [7.1.39.5224]

**Novidade**

* DSML-1382 Atualizado propriedade do numeroRecibo para receber 14 caracteres

## [7.1.39.5221]

**Novidade**

- DSML-1111 - Atualizado MOC para versão 2.10.

- DSML-1017 - Compatibilizado executavel com o Delphi 12 Athenas.


## [7.1.38.5218]

**Novidade**

DSP4G-775 - integração por arquivo no formato JSON pelo novo metodo [ConverterJonParaTx2](https://tecnospeed.zendesk.com/hc/pt-br/articles/20949457527831)


**Correçoes**

**DSML-1007** - Correção para inclusão de campos extras ao enviar uma Guia Sem XML Destinatário e novo parâmetro para impressão, visualização e exportação de GNRe.

**DSML-1064** - Correção para inclusão dos campos de Contribuinte Destinatário do TX2 ao enviar uma Guia sem XML Destinatário.

## [7.1.37.5212]

**Correções**

**Novidades**

**DSML-860** - Adicionado método [EnviarGuiaSemXmlDestinatario ](https://atendimento.tecnospeed.com.br/hc/pt-br/articles/17560744420375/preview/eyJhbGciOiJIUzI1NiJ9.eyJpZCI6MTc1NjA3NDQ0MjAzNzUsInJldmlzaW9uX2lkIjoiMDFIQU1BMEFDTTgwQkdDQkhGRlZFRktGQ0giLCJleHAiOjE2OTUwNDk3ODN9.fnAH54uIfSsQTYJSSlEap8i73AwIUQyGXz2QC0il8UU) para gerar uma guia sem a necessidade de informar um XML Destinatário 

**DSML-551** - Corrigido a rejeição do campo extra apenas no ambiente de homologação

## [6.1.37.5208]

**Correções**

**DSML-780** - Corrigido o campo da impressão "Valor Principal" quando houver Partilha de ICMS

## [6.1.36.5205]

**Correção**
- DSML-575 - Atualização dos códigos de homologação

## [6.1.36.5204]
**Correções**

* DSML-575 - Ajustes dos códigos de documento e receita do ini de homologação
 
 ## [6.1.36.5202]
**Correções**

* [DSML-487 ](https://tecnospeed.atlassian.net/browse/DSML-487)Dependências - Nome do produto após instalação

## [6.1.36.5200]

#Leiame

**Novidades**
* DSP4G-789 - Compatibilizado com atualizações do componente indy

**Correções**
* DSML-333 - Correção de regra para geração de guia no eDoc
* DSML-388 - Correção do código do documento de origem para Rio Grande do Norte`
* DSML-437 - Correção do código do documento de origem para Mato Grosso`

## [6.1.36.5197]

* Corre&ccedil;&otilde;es e melhorias diversos.

## [6.1.36.5195]

**Novidades**
* DSP4G-277 - Alteração do Codigo das receita para o webservice de AL para 90 conforme alteração no Portal da GNRE do estado
* DSP4G-260 - Migrando os arquivos de templates para implementação "hardcoded".
* DSP4G-143 - Adicionado no menu do Windows a opção de desinstalação do pacote de dependências.
* DSP4G-27  - Adicionado método TestarEmailConfig para validar as configurações de email, para mais informações acesse: https://atendimento.tecnospeed.com.br/hc/pt-br/articles/7861404358295
* DSP4G-397 - Adicionado ao pacote de instalação do componente o arquivo "IDs_LIBs_GNRe.ini" contendo os ID´s das OCXs.

## [6.1.36.5193]

**Novidades**
* DSP4G-277 - Alteração do Codigo das receita para o webservice de AL para 90 conforme alteração no Portal da GNRE do estado
* DSP4G-260 - Migrando os arquivos de templates para implementação "hardcoded".
* DSP4G-143 - Adicionado no menu do Windows a opção de desinstalação do pacote de dependências.
* DSP4G-27  - Adicionado método TestarEmailConfig para validar as configurações de email, para mais informações acesse: https://atendimento.tecnospeed.com.br/hc/pt-br/articles/7861404358295

## [6.1.36.5192]

* Corre&ccedil;&otilde;es e melhorias diversos.

## [6.1.36.5191]

- DML-25 - Criar pipeline de testes GitLab

## [6.1.36.5175]
**Novidades**
 - DCIT-1059 - Implementado envio de e-mail com SBB

## [6.1.36.5172]
**Novidades**
 - DCIT-932 - Alterações para permitir o uso de lote de xmls nos métodos ImprimirGnre, VisualizarGnre, ExportarGnre, 
             EditarModeloImpressao e ExtrairDadosRetorno. Para isso basta criar o lote concatenando os xmls de impressão.
             OBS 1: O lote deverá conter xmls da mesma versão (vm100 ou vm200) e tipo (Nacional, ES ou RJ).
             OBS 2: Retornaremos erro caso o lote de xmls esteja fora do padrão indicado na OBS 1.
 - DCIT-953 - Tratamento de retorno de erro faultstring no envio para ES.
















