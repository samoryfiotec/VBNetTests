# Usando SQL Server como Banco de Dados da Aplicação

## 1. Instanciando o SQL Server com Docker

Execute o comando abaixo para criar uma instância do SQL Server no Docker:

```bash
docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=SenhaForte123!" \ 
-p 1433:1433 --name vbnettests \
-v sqlvolume:/var/opt/mssql \
-d mcr.microsoft.com/mssql/server:2022-latest
```

- **SA_PASSWORD**: Defina uma senha forte para o usuário `sa`. (Pode utilizar  o SenhaForte123! que  é um padrão)
- **-p 1433:1433**: Expõe a porta padrão do SQL Server.

## 2. Conectando à Instância

Utilize a string de conexão abaixo na sua aplicação:

```
Server=localhost,1433;Database=vbnettests;User Id=sa;Password=SenhaForte123!;
```

## 3. Criando o Banco de Dados

Após conectar, crie o banco de dados com:

```sql
CREATE DATABASE VBNetTests;
```
## 4. Criar e popular as tabelas

Peque os scripts ddl e dml (criação e manipulação) em \docs\BD\

## 5. Considerações

- Certifique-se de que o Docker está instalado e em execução.
- Pode alterar a senha padrão para ter maior segurança.
- Para acessar via ferramentas como SQL Server Management Studio, use `localhost,1433` como servidor.
