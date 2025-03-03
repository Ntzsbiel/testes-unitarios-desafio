# 📌 DIO - Trilha .NET - Testes Unitários com C#

## 🌍 Sobre o Projeto
Este projeto foi desenvolvido como parte da trilha .NET da DIO, com o objetivo de aplicar testes unitários em um sistema. A implementação de testes garante a confiabilidade do software, evitando erros recorrentes e melhorando sua qualidade.

## 🏆 Objetivo
Implementar testes unitários utilizando **xUnit** para validar as funcionalidades de um sistema, cobrindo cenários positivos e negativos. Dessa forma, garantimos que as principais funcionalidades do sistema estejam sempre funcionando corretamente.

## 📖 Contexto
Os gestores relataram problemas frequentes no software, como:
✅ Bugs inesperados.
✅ Funcionalidades que param de funcionar.
✅ Falhas em validações.

Para resolver isso, foi sugerida a implementação de testes unitários, garantindo maior controle sobre o sistema e aumentando sua confiabilidade.

## 🏗 Estrutura do Projeto
O projeto é composto por dois módulos principais:

📌 **Projeto Console**: Contém a lógica principal do sistema.
📌 **Projeto de Testes**: Contém os testes unitários, escritos com **xUnit**.

![Estrutura do Projeto](Imagens/projeto.png)

## 🛠 Implementação
### 🔹 Classe `ValidacoesLista`
Esta classe realiza operações e validações sobre listas de números inteiros:

| 🏷 Método                        | 🎯 Objetivo |
|------------------------------|------------------------------------------------------------------------------------------------|
| `RemoverNumerosNegativos`    | Remove os números negativos de uma lista e retorna apenas os positivos. |
| `ListaContemDeterminadoNumero` | Verifica se um determinado número está presente na lista. |
| `MultiplicarNumerosLista`     | Multiplica cada número da lista por um fator específico. |
| `RetornarMaiorNumeroLista`    | Retorna o maior número presente na lista. |
| `RetornarMenorNumeroLista`    | Retorna o menor número presente na lista. |

### 🔹 Classe `ValidacoesString`
Responsável por realizar operações e validações sobre strings:

| 🏷 Método                        | 🎯 Objetivo |
|--------------------------------|--------------------------------------------------------------------------------------------------------------------------|
| `RetornarQuantidadeCaracteres` | Retorna a quantidade de caracteres em uma string. |
| `ContemCaractere`               | Verifica se uma palavra está presente no texto fornecido. |
| `TextoTerminaCom`               | Verifica se um texto termina com determinada palavra. |

## 🧪 Implementação dos Testes
Os testes foram implementados no projeto de testes, validando as classes mencionadas acima.

### 🔹 Classe `ValidacoesListaTests`
Esta classe garante o correto funcionamento dos métodos relacionados a listas:

| 🏷 Teste                                      | ✅ Comportamento esperado |
|--------------------------------------------|--------------------------------------------------------------------------|
| `DeveRemoverNumerosNegativosDeUmaLista`   | Deve retornar apenas os números positivos. |
| `DeveConterONumero9NaLista`               | Deve retornar **true** se o número 9 estiver presente na lista. |
| `NaoDeveConterONumero10NaLista`           | Deve retornar **false** se o número 10 não estiver na lista. |
| `DeveMultiplicarOsElementosDaListaPor2`   | Deve retornar uma lista com os elementos multiplicados por 2. |
| `DeveRetornar9ComoMaiorNumeroDaLista`     | Deve retornar **9** como o maior elemento da lista. |
| `DeveRetornarOitoNegativoComoMenorNumeroDaLista` | Deve retornar **-8** como o menor elemento da lista. |

### 🔹 Classe `ValidacoesStringTests`
Garante o funcionamento correto dos métodos relacionados a manipulação de strings:

| 🏷 Teste                                      | ✅ Comportamento esperado |
|----------------------------------------------|------------------------------------------------------------------------------------------------------|
| `DeveRetornar6QuantidadeCaracteresDaPalavraMatrix` | Deve retornar **6** ao contar os caracteres da palavra "Matrix". |
| `DeveContemAPalavraQualquerNoTexto`          | Deve retornar **true** ao verificar se "qualquer" está no texto. |
| `NaoDeveConterAPalavraTesteNoTexto`          | Deve retornar **false** ao verificar se "teste" está no texto. |
| `TextoDeveTerminarComAPalavraProcurado`      | Deve retornar **true** ao verificar se o texto termina com "procurado". |

## 🚀 Conclusão
Com a implementação dos testes unitários, agora temos um sistema mais seguro e confiável. Isso permite que futuras alterações no código sejam feitas sem comprometer a estabilidade do software. 🎯✅

Esperamos que este projeto seja útil para consolidar conhecimentos sobre **Testes Unitários com C#** e sua importância no desenvolvimento de software! 🚀

