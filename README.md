# 💻 TechHelp Support

Sistema de Gestão de Suporte Técnico desenvolvido para informatizar o processo de abertura e gerenciamento de chamados da empresa **TechHelp Support**.

O sistema tem como objetivo organizar a fila de atendimento, facilitando o cadastro de clientes, técnicos e o controle dos chamados técnicos.

---

## 📌 Sobre o Projeto

A **TechHelp Support** realiza atendimentos técnicos em diferentes áreas, como:

- 🌐 Redes
- 🖥️ Hardware
- 💻 Software
- 🔧 Suporte técnico em geral

Atualmente, os clientes solicitam suporte por telefone ou e-mail, dificultando a organização dos atendimentos.

Com o sistema, o processo é informatizado, permitindo que os clientes realizem seu cadastro e, após o login, possam abrir chamados para solicitar atendimento técnico.

---

## 🎯 Objetivo

O objetivo do **TechHelp Support** é proporcionar uma plataforma simples e organizada para:

- Cadastrar clientes;
- Cadastrar técnicos;
- Registrar chamados;
- Agendar atendimentos;
- Acompanhar o status dos chamados;
- Organizar a fila de suporte;
- Facilitar o gerenciamento dos atendimentos técnicos.

---

## 🔐 Sistema de Login

Ao acessar o sistema, a primeira tela apresentada é a **tela de login**.

O cliente deve informar seus dados para acessar o sistema.

Caso ainda não possua cadastro, existe uma opção para realizar seu cadastro.

### Funcionalidades do Login

- Acesso do cliente;
- Validação do usuário;
- Cadastro de novo cliente;
- Restrição de abertura de chamados para usuários não autenticados.

---

## 🏠 Tela Inicial

A tela inicial apresenta a identidade visual do **TechHelp Support**, utilizando uma interface moderna baseada em tons de **roxo, branco e cinza**.

### 📷 Screenshot — Tela Inicial

<img width="1913" height="919" alt="Tela Inicial (2)" src="https://github.com/user-attachments/assets/81580e44-c8b7-4886-8742-0fb794c95466" />


---

## 🔑 Tela de Login

A tela de login permite que o cliente informe seu **CPF** para acessar a área do sistema.

A tela também disponibiliza a opção de cadastro para novos clientes.

### 📷 Screenshot — Tela de Login

<img width="1895" height="908" alt="Tela Login" src="https://github.com/user-attachments/assets/8abd80b3-209c-4bfe-b58c-f4271a742841" />


## 👤 Cadastro do Cliente

O cliente possui um cadastro com seus principais dados pessoais:

| Campo | Descrição |
|---|---|
| **Nome** | Nome completo do cliente |
| **CPF** | Documento de identificação |
| **Telefone** | Telefone para contato |
| **Data de Nascimento** | Data de nascimento do cliente |

Após realizar o cadastro, o cliente poderá acessar o sistema através do login.

---

## 🧑‍🔧 Cadastro do Técnico

O sistema também possui cadastro dos técnicos responsáveis pelos atendimentos.

Cada técnico possui:

| Campo | Descrição |
|---|---|
| **Nome** | Nome do técnico |
| **Registro Técnico** | Registro profissional do técnico |
| **Especialidade** | Área de atuação |

### Exemplos de especialidades

- Redes
- Hardware
- Software
- Manutenção
- Suporte técnico

---

## 🎫 Chamados

O **Chamado** representa uma ordem de serviço aberta pelo cliente para solicitar atendimento técnico.

Cada chamado registra as principais informações necessárias para o atendimento.

### Informações do chamado

- 👤 Cliente responsável;
- 🧑‍🔧 Técnico responsável;
- 📅 Data e hora agendada;
- 📌 Status do atendimento.

### Status disponíveis

| Status | Descrição |
|---|---|
| 🟣 **Agendada** | Atendimento marcado para uma data futura |
| 🟢 **Realizada** | Atendimento concluído |
| 🔴 **Cancelada** | Atendimento cancelado |

---

## 🔒 Controle de Acesso

Para garantir a organização do sistema, somente clientes **autenticados** podem realizar a abertura de chamados.

O fluxo principal do sistema é:

```text
                 ┌───────────────┐
                 │     Início    │
                 └───────┬───────┘
                         │
                         ▼
                 ┌───────────────┐
                 │     Login     │
                 └───────┬───────┘
                         │
                ┌────────┴────────┐
                │                 │
          Cadastrado        Não cadastrado
                │                 │
                ▼                 ▼
         ┌────────────┐    ┌──────────────┐
         │   Acesso   │    │   Cadastro   │
         └─────┬──────┘    └──────┬───────┘
               │                  │
               └────────┬─────────┘
                        ▼
               ┌─────────────────┐
               │  Abrir Chamado  │
               └─────────────────┘

🎓 Projeto Acadêmico
Este projeto foi desenvolvido com finalidade acadêmica, colocando em prática conceitos de:

Desenvolvimento Web;

Programação em C#;

ASP.NET Core MVC;

Banco de dados;

Entity Framework;

CRUD;

Autenticação;

Controle de acesso;

HTML e CSS;

Interface de usuário.

👨‍💻 Autor
Ryan Josias Lima

👨‍🏫 Professor
Wallace Oliveira

📅 Ano
2026


