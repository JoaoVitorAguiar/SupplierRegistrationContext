# Sistema de Cadastro de Fornecedores

Este projeto consiste em um Sistema de Cadastro de Fornecedores que permite aos usuários realizar operações básicas de CRUD em registros de fornecedores. O sistema é construído utilizando várias tecnologias, conforme especificado abaixo.
##
<p align="center">
  <img src="https://github.com/JoaoVitorAguiar/SupplierRegistrationContext/blob/main/Cadastro-fornecedores-VitorTech-%E2%80%90-Feito-com-o-Clipchamp.gif" width="700" />
</p>

## Tecnologias Utilizadas

- Visual Studio 2022 Community
- SQL Server Express ou MySQL
- ASP.NET Core Razor Pages
- Entity Framework
- HTML, Bootstrap e CSS para desenvolvimento e estilização do front-end

## Objetivo

O objetivo principal deste projeto é criar um Sistema de Cadastro de Fornecedores utilizando as tecnologias especificadas. O sistema deve fornecer as operações básicas de CRUD (Criar, Ler, Atualizar, Excluir) para gerenciar registros de fornecedores.

## Funcionalidades

- **Cadastrar Fornecedor:** Os usuários podem criar novos registros de fornecedores fornecendo as seguintes informações:
  - Nome (limitado a 100 caracteres)
  - CNPJ (valor numérico com 14 dígitos)
  - Especialidade (opção de seleção com escolhas: "Comércio," "Serviço," "Indústria")
  - CEP (valor numérico com 8 dígitos)
  - O endereço será preenchido automaticamente quando o CEP for inserido, utilizando a API ViaCEP para consulta de endereços.

- **Visualizar Fornecedores:** Os usuários podem visualizar uma lista de todos os fornecedores registrados. As informações de cada fornecedor, incluindo ID, Nome, CNPJ, Especialidade e CEP, serão exibidas.

- **Atualizar Fornecedor:** Os usuários podem editar e atualizar as informações dos fornecedores existentes. Os mesmos atributos do processo de criação podem ser modificados.

- **Excluir Fornecedor:** Os usuários podem excluir registros de fornecedores do sistema, removendo-os efetivamente do banco de dados.

## Como Começar

Siga os passos abaixo para colocar o projeto em funcionamento em sua máquina local:

1. Clone o repositório: `git clone https://github.com/JoaoVitorAguiar/SupplierRegistrationContext.git`
2. Abra o projeto no Visual Studio 2022 Community.
3. Configure o banco de dados usando SQL Server Express ou MySQL.
4. Compile e execute o projeto usando ASP.NET Core MVC ou ASP.NET Core Razor Pages.
5. Acesse a aplicação através do seu navegador web.

Por favor, note que este é um guia básico e você pode precisar ajustar algumas configurações com base em seu ambiente específico.

## Créditos

Este projeto foi criado por mim, Vitor Aguiar como uma demonstração do uso de várias tecnologias para a construção de um Sistema de Cadastro de Fornecedores. Ele utiliza bibliotecas e APIs de código aberto para uma experiência do usuário tranquila.

