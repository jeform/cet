# cet
Método de cálculo do Custo Efetivo Total (CET)

Custo Efetivo Total (CET) é a taxa que considera todos os encargos e despesas incidentes nas operações de crédito e de arrendamento mercantil financeiro, contratadas ou ofertadas a pessoas físicas, microempresas ou empresas de pequeno porte.

Fonte: http://www.bcb.gov.br/pre/bc_atende/port/custo.asp

Para validação do cálculo, acesse o site do PROCON pela URL http://www.procon.sp.gov.br/webcet/index.html
No link acima há um simulador do cálculo.
          
Exemplo de chamada do método:

DateTime dataContrato = Convert.ToDateTime("12/04/2018");
DateTime dataParcela = Convert.ToDateTime("07/06/2018");
Double valorFinanciado = 2000.00;
Double valorParcela = 200.00;
int prazo = 12;

MessageBox.Show(CalcularCet(valorFinanciado, valorParcela, prazo, dataContrato, dataParcela).ToString());

