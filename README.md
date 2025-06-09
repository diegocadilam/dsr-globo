# **Descrição técnica da solução**

Implementação de uma API com:

1.  Swagger para documentação e utilização;
2.  Serviço com uso de um array de Dictionary com o mapeamento do código Morse;
3.  Injeção de Dependência;
4.  Testes Unitários (XUnit) para o serviço.

## **Detalhes da implementação:** 

1.  Criado projeto **DSR-Globo.Service** para implementação da tradução
    1.  Criação da interface IMorseTranslatorService, contendo o contrato a ser implementado
    2.  Criação da classe MorseTranslatorService, onde se encontra de forma estática a conversão do Código Morse através de um array de Dictionary.
2.  Criado projeto **DSR-Globo.Tests** para testar a implementaão de MorseTranslatorService.
    1.  Validar se o algoritmo converte corretamente as frases:
        1.  HEY JUDE
        2.  GLOBO E VC TUDO A VE
3.  Criado o projeto **DSR-Globo** afim de expor a API, com parametro via QueryParams, para tradução do código Morse.
    1.  Gerada a injeção de dependência da Interface IMorseTranslatorService e consumindo o serviço via Controller.

# Instruções para rodar o programa

`dotnet run --project DSR-Globo/DSR-Globo.csproj --urls "http://localhost:5000"`

Para utilizar a API:

1.  Abra o seu navegador de preferência
2.  Cole a URL [`http://localhost:5000/swagger/index.html`](http://localhost:5000/swagger/index.html)
3.  Expanda a seção Translate
4.  Clique no botão Try it out
5.  Insira o código morse
6.  Clique em Execute
7.  A tradução deve aparecer imediatamente abaixo no retorno da API.

# Instruções para rodar os testes

1.  Abra o terminal onde o projeto foi clonado
2.  Execute cd DSR-Globo.Tests
3.  Execute dotnet test
4.  O resultado dos testes deve aparecer no terminal
