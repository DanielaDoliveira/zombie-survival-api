# zombie-survival-api
Este projeto é uma API Rest para o jogo de sobrevivência a Zumbis da Alura. o objetivo aqui é a aplicação dos conhecimentos recém adquiridos do curso de ASP .NET 6  e incrementar a funcionalidade dos jogadores poderem ter seus nomes e pontuações exibidos de forma online e visível a todos.


- A APi contém 3 campos:
    - ID
    - User Name
    - Survival Time
    
    Serão exibidos o placar com os 10 melhores jogadores. Isto será definido pelo tempo de sobrevivência ( Survival Time)


Get : base/ranking - Captura os 10 primeiros jogadores
Get: base/ranking?skip=0&take=2 : Exemplo com paginação. Nesse caso ele pula nenhum registro e pega os dois primeiros na ordem de maior pontuação.

Post: base/ranking - Cria um novo registro

Delete: base/id - Deleta um registro pelo seu id

