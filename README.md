# Sistema de Pagamentos - C# FIAP

Projeto da disciplina de C# Software Development - FIAP.

## Integrante

- Luiz Henrique Dos Reis Grabe — RM556001 — Turma 3ESPV

## O que o projeto faz

É uma aplicação de console que simula um sistema de pagamentos. Ao rodar o programa, aparece um menu no terminal onde você escolhe entre pagar com cartão, pagar com boleto, ou encerrar. Depois de escolher, o sistema pede o valor e os dados do pagamento, e exibe uma mensagemm de confirmação.

## Como rodar

Precisa ter o .NET SDK instalado.

Com o SDK instalado, entre na pasta do projeto e rode:

```
dotnet run
```

## Estrutura de pastas

```
SistemaPagamentos/
├── Models/
│   ├── Pagamento.cs
│   ├── PagamentoCartao.cs
│   └── PagamentoBoleto.cs
├── UI/
│   └── Menu.cs
└── Program.cs
```

A pasta `Models` tem as classes de pagamento. A pasta `UI` tem a classe estática do menu. O `Program.cs` é o ponto de entrada com o looping principal.

## Decisões de implementação

- O valor foi declarado como `decimal` porque é o tipo mais adequado para dinheiro em C# (evita os problemas de precisão do `float` e `double`)
- Número do cartão e código de barras são `string` porque não fazem sentido como número — não tem operação matemática e podem ter traços ou zeros à esquerda
- A data é `DateTime`, gerada automaticamente no momento do pagamento
- O sistema aceita vírgula e ponto como separador decimal (ex: `175,50` e `175.50` funcionam os dois)

## Conceitos de POO usados

- `Pagamento` é uma classe abstrata com o método `ProcessarPagamento()` também abstrato
- `PagamentoCartao` e `PagamentoBoleto` herdam de `Pagamento` e cada uma implementa o método do seu jeito (polimorfismo)
- `Menu` é uma classe estática com o método `ExibirMenu()` como exigido no enunciado

## Evidências de teste

### Pagamento com Cartão
--

### Pagamento com Boleto
--

### Valor com ponto no lugar de vírgula
--

### Opção inválida e encerramento
--
