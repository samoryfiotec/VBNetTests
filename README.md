# VBNetTests

Este repositório contém testes desenvolvidos em VB.NET para validar funcionalidades e garantir a qualidade do código.

![.NET Framework](https://img.shields.io/badge/.NET_Framework-4.8-blue) ![VB.NET](https://img.shields.io/badge/VB.NET-Visual_Studio-purple) ![Visual Studio](https://img.shields.io/badge/Visual_Studio-2022-blueviolet) ![NUnit3](https://img.shields.io/badge/NUnit-3.13.3-green) ![Moq](https://img.shields.io/badge/Moq-4.18.2-orange) 
![FluentValidation](https://img.shields.io/badge/FluentValidation-8.6.3-yellow)

## Estrutura do Projeto

- **`VBNet.Domain`**: Aqui estão as entidades do projeto.
- **`VBNet.Infra`**: A camada de Ports e Adapters.
- **`VBNet.Service`**: Projeto que contém o negócio.
- **`VBNet.Tests`**: O projeto de testes.

## Pré-requisitos

- Visual Studio 2022
- .NET Framework 4.8
- Docker Desktop

## Banco de Dados

- Vamos utilizar o SQL Server via Docker
- Siga as instruções [por aqui](BancoDados.md).

## Frameworks de Testes

### NUnit3 3.13.3

> É uma estrutura de testes unitários para .NET que permite escrever e executar testes automatizados para verificar o comportamento e a qualidade do código.

### Moq 4.18.2

> É uma biblioteca de mocking para .NET que permite criar objetos simulados para testes unitários, facilitando a verificação de interações e comportamentos em código testado.

## Validação

### FluentValidation.8.6.3

> É um pacote .NET para criação de regras de validação fortemente tipadas e fluentes para objetos, facilitando a validação de dados de forma clara e reutilizável.

## Como Executar os Testes

1. Clone este repositório:

    ```bash
    git clone https://github.com/usuario/VBNetTests.git
    ```

2. Abra o projeto na sua IDE.
3. Compile a solução para restaurar os pacotes necessários.
4. Execute os testes usando o Test Explorer caso esteja usando o Visual Studio 2022.

## NUnit3 - Definição

NUnit3 é um framework de testes unitários para .NET que facilita a criação e execução de testes automatizados, suportando várias asserções e parametrizações.

## Moq - Utilização

Não precisa de Injeção de dependência para utilizar o Moq nesta versão do .NET Framework 4.8 mas é necessário que os métodos (Sub) implementem interfaces para isso.

## Fine Code Coverage

Fine Code Coverage é uma extensão para Visual Studio que permite visualizar a cobertura de código diretamente na IDE. Ele integra-se ao Test Explorer e fornece relatórios detalhados sobre quais partes do código foram cobertas pelos testes.

### Como Funciona

1. **Instrumentação do Código**: Durante a execução dos testes, o Fine Code Coverage analisa o código-fonte e identifica quais linhas foram executadas.
2. **Relatórios Visuais**: Ele gera relatórios em HTML e destaca as linhas cobertas e não cobertas diretamente no editor de código.
3. **Integração com Testes**: Funciona com frameworks de teste como NUnit, MSTest e xUnit.

### Como Baixar e Instalar

Para instalar o Fine Code Coverage, siga os passos abaixo:

1. Acesse o [Visual Studio Marketplace](https://marketplace.visualstudio.com/items?itemName=FortuneNgwenya.FineCodeCoverage2022).
2. Clique no botão **Download** para baixar a extensão.
3. Abra o arquivo baixado para iniciar a instalação.
4. Siga as instruções do instalador para concluir a instalação.
5. Reinicie o Visual Studio para ativar a extensão.

Após a instalação, o Fine Code Coverage estará disponível no Test Explorer do Visual Studio.

Para mais informações, consulte a [documentação oficial](https://github.com/FineCodeCoverage/FineCodeCoverage).

## Arquitetura

![Container Diagram](out/docs/C4/Container/ContainerVBNetTests.png)

## Contribuição

Além de clonar e testar na sua própria máquina você pode incluir as suas próprias entidades e métodos para criar os seus testes. Só criar sua própria branch e submeter um pull request.

Acompanhe as discussões na aba "Issue" aqui neste respositório.

Clique em watch para ser avisado das atualizações deste repo.

## Licença

Este projeto está licenciado sob a [Licença BSD-3-Clause](LICENSE).
