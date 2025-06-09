# 📦 LojaApp - Sistema de Vendas com .NET MAUI

Este é um projeto de sistema de vendas desenvolvido com **.NET MAUI**, focado em lojas físicas que precisam de controle de **produtos**, **vendas** e **estoque**, com possibilidade futura de integração com API web e apps móveis.

---

## 🚀 Funcionalidades

- 📋 Cadastro de produtos (com código de barras)
- 🛒 Registro de vendas com múltiplos itens
- 📦 Controle de estoque automatizado
- 💾 Armazenamento local com SQLite (Por Enquanto)
- ✅ Estrutura modular e escalável
- 🌐 Preparado para consumo de API (integração futura)

---

## 🧱 Estrutura de Pastas

```bash
LojaApp/
├── Models/              # Classes de dados (Produto, Venda, ItemVenda)
├── ViewModels/          # Camada de lógica e binding com a UI
├── Views/               # Interfaces gráficas (Pages)
├── Services/            # Lógica de negócios e acesso a dados
├── Database/            # Conexão e manipulação do banco SQLite
├── Helpers/             # Utilitários, enums e validações
├── Resources/           # Fontes e imagens
├── App.xaml             # Estilos globais
├── Program.cs           # Configuração principal do aplicativo
└── MainPage.xaml        # Tela inicial
