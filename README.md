# 📊 IBGE Data Insights - Nomes por Localidade (Censo 2022)

O **IBGE Data Insights** é uma aplicação desenvolvida em C# e .NET MAUI focada no consumo dinâmico e encadeado de APIs REST. Utilizando o padrão de arquitetura em camadas para separar regras de negócio, serviços HTTP e interface gráfica, o sistema liga-se às APIs abertas do IBGE (Localidades e Nomes). O objetivo da ferramenta é cruzar dados geográficos e demográficos em tempo real, permitindo aos utilizadores descobrir instantaneamente os nomes mais registados na sua região, de acordo com o Censo 2022.

## 👥 Integrantes da Equipa
- Pablo Henrique Silva Calogi
- Juliano Tempesta


## 🏗 Arquitetura
O projeto foi estruturado seguindo o padrão de separação de responsabilidades:
- **Models:** POCOs para mapeamento da estrutura JSON retornada pelo IBGE (`Estado`, `NomeResult`).
- **Services:** Isolamento da lógica HTTP utilizando `HttpClient` para requisições assíncronas externas.
- **Views (UI):** Interfaces construídas em XAML, com Binding de dados para `Picker` e `CollectionView`.

## 🚀 Como Executar o Projeto
1. Clone o repositório:
   ```bash
   git clone [https://github.com/SeuUsuario/IBGE-DataInsights.git](https://github.com/SeuUsuario/IBGE-DataInsights.git)
