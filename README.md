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

## Imagens do Projeto
### Tela de Login
<img src="https://github.com/user-attachments/assets/b20ffd6e-cd36-432e-a4f4-dac55f059829" width="300">

### Validação do Login
<img src="https://github.com/user-attachments/assets/b15baef0-285f-4e85-a905-1722d69aa209" width="300">

### Escolher Gênero
<img src="https://github.com/user-attachments/assets/7e0479b0-751c-4ab0-a1fa-900d67f71b15" width="300">

### Cálculo do Tempo de Contribuição
<img src="https://github.com/user-attachments/assets/24ada530-d16d-4282-ae9e-cdffa9e91ef2" width="300">




