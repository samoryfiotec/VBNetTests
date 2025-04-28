# VBNetTests

Este repositório contém testes desenvolvidos em VB.NET para validar funcionalidades e garantir a qualidade do código.

![.NET Framework](https://img.shields.io/badge/.NET_Framework-4.8-blue) ![VB.NET](https://img.shields.io/badge/VB.NET-Visual_Studio-purple) ![Visual Studio](https://img.shields.io/badge/Visual_Studio-2022-blueviolet) ![NUnit3](https://img.shields.io/badge/NUnit-3.13.3-green) ![Moq](https://img.shields.io/badge/Moq-4.18.2-orange)
## Estrutura do Projeto

- **`/ConsoleVB`**: Contém os arquivos de teste.
- **`/ConsoleVB.Tests`**: Contém o código-fonte principal.

## Pré-requisitos

- Visual Studio ou Visual Studio Code instalado.
- .NET Framework 4.8

## Como Executar os Testes

1. Clone este repositório:
    ```bash
    git clone https://github.com/usuario/VBNetTests.git
    ```
2. Abra o projeto na sua IDE.
3. Compile a solução para restaurar os pacotes necessários.
4. Execute os testes usando o Test Explorer caso esteja usando o Visual Studio 2022.
5. Caso esteja usando o Visual Studio Code, execute os testes via linha de comando utilizando o seguinte comando:
    ```bash
    dotnet test
    ```
## Arquitetura

![Container Diagram](out/docs/C4/Container/ContainerVBNetTests.png)

## Contribuição

Além de clonar e testar na sua própria máquina você pode incluir as suas próprias entidades e métodos para criar os seus testes. Só criar sua própria branch e submeter um pull request.

Acompanhe as discussões na aba "Issue" aqui neste respositório.

Clique em watch para ser avisado das atualizações deste repo.

## Licença

Este projeto está licenciado sob a [MIT License](LICENSE).
