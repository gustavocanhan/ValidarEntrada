# 🧠 Projeto: Validação de Entrada em C#

Este projeto foi criado com o objetivo de **aprender e praticar validações de entrada no console em C#**.  
O programa apresenta um menu interativo com três tipos de validações diferentes, permitindo testar como o C# lida com entradas de texto, números e caracteres.

---

## 🎯 Objetivo

O foco principal é **entender e implementar diferentes formas de validar dados digitados pelo usuário**, incluindo:
- uso de `TryParse` para validação de inteiros;
- verificação de strings vazias;
- aplicação de expressões regulares (Regex);
- controle de repetição com `while`;
- mensagens específicas para cada tipo de erro.

---

## 📋 Funcionalidades

### 1️⃣ Validar entrada **0 ou 1 como texto**
Classe: `ValidaZeroUm.ValidaEntradaZeroUmTexto()`

- Aceita apenas `"0"` ou `"1"` como string.  
- Usa `Trim()` para remover espaços extras.  
- Exibe mensagens personalizadas:
  - **Entrada vazia**
  - **Entrada inválida** (quando não é 0 ou 1)
  - **Entrada válida** (quando o valor é aceito)

---

### 2️⃣ Validar entrada **0 ou 1 como número inteiro**
Classe: `ValidaZeroUm.ValidaEntradaZeroUmInteiro()`

- Usa `int.TryParse()` para converter o texto em número com segurança.  
- Evita exceções se o usuário digitar letras ou símbolos.  
- Exibe mensagens:
  - **Entrada inválida! Digite um número inteiro.**
  - **Entrada inválida! Digite 0 ou 1.**
  - **Entrada válida** (quando o valor é 0 ou 1)

---

### 3️⃣ Validar **caractere de A-Z ou a-z**
Classe: `ValidaCaractere.ValidaEntradaCaractere()`

- Permite digitar apenas **um caractere alfabético**.  
- Usa **expressões regulares (Regex)** para detectar:
  - **Números**
  - **Caracteres especiais**
- Exibe mensagens:
  - **Entrada vazia**
  - **Digite apenas um caractere**
  - **Número não é permitido**
  - **Caractere especial não é permitido**
  - **Entrada válida**

---

## 🧩 Estrutura do Menu

Classe principal: `Program.cs`

- Exibe o menu com as opções:
  ```
  1 - Validar entrada 0 e 1 como texto
  2 - Validar entrada 0 e 1 como inteiro
  3 - Validar caractere de A-Z ou a-z
  0 - Sair
  ```
- Usa `while (opcaoMenu != 0)` para manter o programa rodando até o usuário escolher sair.  
- Valida o menu com `int.TryParse()` para evitar erros de conversão.

---

## 💡 Conceitos Praticados

- `int.TryParse()` e `string.IsNullOrWhiteSpace()`
- Estruturas de repetição `while`
- Uso de `Regex` para validação de padrões
- Estrutura de `switch` com menu
- Separação de código em classes (`ValidaZeroUm` e `ValidaCaractere`)
- Mensagens de erro e controle de fluxo

---

## 🚀 Como executar

1. Abra o projeto no Visual Studio ou VS Code.
2. Compile com `Ctrl + F5` (ou `dotnet run` no terminal).
3. Escolha uma das opções do menu e digite as entradas para testar.

---

## 📚 Aprendizado

Durante o desenvolvimento, foram praticados:
- diferentes formas de **tratar erros de entrada do usuário**;
- controle de repetição e retorno em loops;
- como **separar responsabilidades em classes**;
- e como **exibir mensagens específicas** para cada tipo de validação.
