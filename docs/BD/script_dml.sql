-- Inserção de dados de teste para as tabelas Cliente, Produto e Pedido do banco de dados VBNetTests
-- Use o banco de dados VBNetTests
USE VBNetTests;

-- Inserir Clientes
INSERT INTO Cliente (Nome, Email, Telefone, Endereco) VALUES
(N'Ana Silva', N'ana.silva@email.com', N'(11) 99999-0001', N'Rua das Flores, 100'),
(N'Bruno Souza', N'bruno.souza@email.com', N'(21) 98888-0002', N'Avenida Brasil, 200'),
(N'Carla Pereira', N'carla.pereira@email.com', N'(31) 97777-0003', N'Praça Central, 300'),
(N'Daniel Costa', N'daniel.costa@email.com', N'(41) 96666-0004', N'Rua do Sol, 400'),
(N'Elisa Ramos', N'elisa.ramos@email.com', N'(51) 95555-0005', N'Avenida das Américas, 500'),
(N'Fábio Lima', N'fabio.lima@email.com', N'(61) 94444-0006', N'Rua das Palmeiras, 600'),
(N'Gabriela Rocha', N'gabriela.rocha@email.com', N'(71) 93333-0007', N'Rua do Comércio, 700'),
(N'Henrique Alves', N'henrique.alves@email.com', N'(81) 92222-0008', N'Avenida Paulista, 800'),
(N'Isabela Martins', N'isabela.martins@email.com', N'(91) 91111-0009', N'Rua das Acácias, 900'),
(N'João Pedro', N'joao.pedro@email.com', N'(11) 90000-0010', N'Rua das Laranjeiras, 1000');

-- Inserir Produtos
INSERT INTO Produto (Nome, Preco, QuantidadeEmEstoque, Categoria) VALUES
(N'Notebook Dell', 3500.00, 15, N'Informática'),
(N'Smartphone Samsung', 2200.00, 30, N'Eletrônicos'),
(N'Fone de Ouvido JBL', 350.00, 50, N'Acessórios'),
(N'Mouse Logitech', 120.00, 40, N'Informática'),
(N'Cadeira Gamer', 950.00, 10, N'Móveis'),
(N'Monitor LG 24"', 1100.00, 20, N'Informática'),
(N'Impressora HP', 800.00, 12, N'Informática'),
(N'Kindle Paperwhite', 600.00, 18, N'Eletrônicos'),
(N'Webcam Microsoft', 250.00, 25, N'Acessórios'),
(N'HD Externo 1TB', 400.00, 22, N'Informática');

-- Inserir Pedidos (ClienteId de 1 a 10)
INSERT INTO Pedido (ClienteId, Data, ValorTotal) VALUES
(1, GETDATE()-10, 3500.00),
(2, GETDATE()-9, 2200.00),
(3, GETDATE()-8, 470.00),
(4, GETDATE()-7, 950.00),
(5, GETDATE()-6, 1100.00),
(6, GETDATE()-5, 800.00),
(7, GETDATE()-4, 600.00),
(8, GETDATE()-3, 250.00),
(9, GETDATE()-2, 400.00),
(10, GETDATE()-1, 120.00);