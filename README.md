# App Hello-Dotnet

Esta é uma imagem Docker baseada em **.NET 6** que demonstra o uso de gerenciamento de recursos (_Feature Management_) via variáveis de ambiente.

## Variáveis de Ambiente

A aplicação aceita a seguinte variável para controlar dinamicamente o comportamento de suas funcionalidades:

| Variável                           | Descrição                                                            | Valores Aceitos   | Padrão  |
| :--------------------------------- | :------------------------------------------------------------------- | :---------------- | :------ |
| `FeatureManagement__BooleanFilter` | Ativa ou desativa o filtro booleano (_Feature Toggle_) na aplicação. | `true` ou `false` | `false` |

---

## Como Rodar o Container (Exemplos Práticos)

Abaixo estão os comandos para testar a imagem localmente alterando o comportamento da funcionalidade.

### 1. Rodando com a Feature Desativada (`false`)

Para subir o container mapeando a porta local `8080` para a porta interna `80` e desativando a feature flag:

````bash
docker run --rm -d \
  -p 8080:80 \
  --name teste \
  -e FeatureManagement__BooleanFilter=false \
  vtamorims/hello-dotnet:7

### 1. Rodando com a Feature ativada (`true`)
Para subir o container mapeando a porta local `8080` para a porta interna `80` e desativando a feature flag:

```bash
docker run --rm -d \
  -p 8080:80 \
  --name teste \
  -e FeatureManagement__BooleanFilter=true \
  vtamorims/hello-dotnet:7

### Verificando o resultado
via browser - http://localhost:8080/swagger e execute o recurso de endpoint dispónível

````
