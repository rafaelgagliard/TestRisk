# Teste Risco BR

O projeto espera tr�s par�metros:
- Uma data (no formato MM/dd/yyyy)
- Um n�mero
- Uma lista de objetos (no formato "int string data(MM/dd/yyyy)" separados por espa�o)

Na lista de objetos, a string espera apenas os valores "Private" e "Public".

N�o h� valida��es de exce��es na aplica��o. Logo n�o ser�o aceitos datas em formatos diferentes, textos quando � esperado n�mero e texto diferente do especificado.


Para casos onde necessitar incluir novas regras � necess�rio:
- Incluir um novo Specification, extendendo a classe ISpecification\<ITrade> na pasta Core/Specifications
- Incluir o Specification criado na lista da classe Core.Specification.SpecificationList

