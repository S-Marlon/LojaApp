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
```


## ⚙️ Tecnologias Utilizadas

```bash
| Camada              | Tecnologia                  |
| ------------------- | --------------------------- |
| UI (Mobile/Desktop) | .NET MAUI + XAML            |
| Backend local       | SQLite via SQLiteAsync      |
| Linguagem           | C#                          |
| Padrão arquitetural | MVVM (Model-View-ViewModel) |
```

## 🛠 Próximos Recursos

- 🔍 Scanner de código de barras
- ☁️ Integração com API em ASP.NET Core
- 📈 Tela de relatórios de vendas
- 👥 Gerenciamento de usuários e permissões
- 🖥 Web app de administração (futuro) 
- 📱 Aplicativo móvel (Android/iOS) com Xamarin.Forms
- 📦 Publicação no NuGet (futuro)
- 📚 Documentação completa
- 🎨 Temas personalizáveis
- 🔒 Autenticação e autorização
- 📊 Dashboard de métricas
- 📦 Suporte a plugins e extensões
- 📦 Integração com serviços de terceiros (pagamentos, envio, etc.)

## 📄 Licença
Este projeto é licenciado sob a licença MIT. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.

## 📞 Contato
Desenvolvido por [Seu Nome ou Nome da Empresa]
📧 Email: seuemail@exemplo.com
🌐 Site: www.seusite.com.br (opcional)


``` xaml
<!-- +-----------------------------------------------------+
| Bem-vindo(a), [Nome do Usuário]                     |
| Loja: [Nome da Loja]                                |
+-----------------------------------------------------+
| 📦 [Cadastrar Produto]        🛒 [Nova Venda]        |
| 🧾 [Histórico de Vendas]      📊 [Relatórios]        |
| 🧰 [Gerenciar Estoque]        ⚙️ [Configurações]     |
+-----------------------------------------------------+
| 📌 Últimas Vendas / Notificações / Alertas de Estoque
+-----------------------------------------------------+
+-----------------------------------------------------+ -->

<<!--
        
        1. Botões para navegação
🛒 Nova Venda → ir para a tela de PDV

📦 Produtos → tela de gerenciamento/cadastro de produtos

🧾 Vendas → lista de vendas realizadas

📊 Relatórios → análise de faturamento, vendas, estoque

⚙️ Configurações → backup, conexões, API, login

2. Informações rápidas (opcional)
Total de vendas do dia

Produtos com estoque baixo

Última venda realizada

Aviso: "Último backup há X dias"

3. Estilo
Ícones ou botões grandes (foco em usabilidade)

Design limpo e intuitivo

Compatível com toque (se for usado em tablet)
        
        -->

```

