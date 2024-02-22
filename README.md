# Zombie Survival API
![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white) ![MySQL](https://img.shields.io/badge/mysql-%2300f.svg?style=for-the-badge&logo=mysql&logoColor=white)

Descrição: Este projeto é uma API Rest para o jogo de sobrevivência a Zumbis da Alura. o objetivo aqui é a aplicação dos conhecimentos recém adquiridos do curso de ASP .NET 6  e incrementar a funcionalidade dos jogadores poderem ter seus nomes e pontuações exibidos de forma online e visível a todos.


- A APi conecta-se com um banco de dados e uma tabela chamada de RankingBoard que contém 3 campos:
    - ID
    - User Name
    - Survival Time


## Métodos
Get : base/ranking - Captura os 10 melhores jogadores.Isto será definido pelo tempo de sobrevivência ( Survival Time)
Get: base/ranking?skip=0&take=2 : Exemplo com paginação. Nesse caso ele pula nenhum registro e pega os dois primeiros na ordem de maior pontuação.

Post: base/ranking - Cria um novo registro

Delete: base/id - Deleta um registro pelo seu id

## Como testar?

Para testar a api, use o comando :

```git clone https://github.com/DanielaDoliveira/zombie-survival-api.git ```

Com o projeto aberto em seu computador, execute

``` dotnet run ```

O App irá fornecer um localhost e porta e executará na sua máquina. Basta substituir o "base" pelo localhost e a porta correspondente.

