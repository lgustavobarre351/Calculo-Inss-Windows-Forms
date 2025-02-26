# Simulador de Aposentadoria - INSS

Este projeto é uma aplicação Windows Forms em C# que calcula a elegibilidade para aposentadoria com base na idade e no tempo de contribuição do usuário.

## Funcionalidades

- **Login:** Permite que o usuário acesse o sistema com um e-mail e senha pré-definidos.
- **Seleção de Gênero:** O usuário escolhe entre as opções Masculino ou Feminino.
- **Cálculo do INSS:** Com base nos dados inseridos, o sistema informa se o usuário já pode se aposentar ou quantos anos ainda faltam.

## Requisitos

- .NET Framework instalado
- Visual Studio para execução e desenvolvimento

## Como Usar

1. Execute o programa e faça login com:
   - **E-mail:** `rm99210@fiap.com.br`
   - **Senha:** `123456`
2. Escolha seu gênero na tela seguinte.
3. Informe sua idade e tempo de contribuição.
4. O sistema calculará automaticamente se você já pode se aposentar.

## Estrutura do Código

- `pag_login.cs`: Implementa a tela de login.
- `sexo.cs`: Permite a escolha de gênero.
- `inssmas.cs`: Calcula a aposentadoria para homens.
- `inssfem.cs`: Calcula a aposentadoria para mulheres.

## Autor

Desenvolvido para fins acadêmicos.
