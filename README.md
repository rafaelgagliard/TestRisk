# Teste Risco BR

O projeto espera três parâmetros:
- Uma data (no formato MM/dd/yyyy)
- Um número
- Uma lista de objetos (no formato "int string data(MM/dd/yyyy)" separados por espaço)

Na lista de objetos, a string espera apenas os valores "Private" e "Public".

Não há validações de exceções na aplicação. Logo não serão aceitos datas em formatos diferentes, textos quando é esperado número e texto diferente do especificado.


Para casos onde necessitar incluir novas regras é necessário:
- Incluir um novo Specification, extendendo a classe ISpecification\<ITrade> na pasta Core/Specifications
- Incluir o Specification criado na lista da classe Core.Specification.SpecificationList

