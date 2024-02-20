# zombie-survival-api
Este projeto é uma API Rest que funciona com o projeto do jogo de sobrevivência a Zumbis da Alura. o objetivo aqui é a aplicação dos conhecimentos recém adquiridos do curso de ASP .NET 6  e incrementar a funcionalidade dos jogadores poderem ter seus nomes e pontuações exibidos de forma online e visível a todos.


- A APi contém 3 campos:
    - ID
    - User Name
    - Survival Time
    - 
    
    Serão exibidos o placar com os 10 melhores jogadores:
    
    - maior tempo de sobrevivência


Get : base/ranking - Captura os 10 primeiros jogadores

Post: base/ranking - Cria um novo registro

Delete: base/ranking?skip=10 - Deleta a partir do décimo primeiro usuário

