## [6.1.36.5172]
**Novidades**
 - DCIT-932 - Alterações para permitir o uso de lote de xmls nos métodos ImprimirGnre, VisualizarGnre, ExportarGnre, 
             EditarModeloImpressao e ExtrairDadosRetorno. Para isso basta criar o lote concatenando os xmls de impressão.
             OBS 1: O lote deverá conter xmls da mesma versão (vm100 ou vm200) e tipo (Nacional, ES ou RJ).
             OBS 2: Retornaremos erro caso o lote de xmls esteja fora do padrão indicado na OBS 1.
 - DCIT-953 - Tratamento de retorno de erro faultstring no envio para ES.