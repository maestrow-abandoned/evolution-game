namespace Web

open WebSharper
open WebSharper.Core.Resources
open WebSharper.JavaScript
open WebSharper.JQuery
open WebSharper.UI.Next
open WebSharper.UI.Next.Html
open WebSharper.UI.Next.Client

module srv = Domain.Services
module gen = Domain.RandomGameStateGenerator

[<JavaScript>]
module Client = 
  let players = gen.createGameState srv.fullDeck
  let Main = 
    players
    |> Components.createGameView
    |> Doc.RunById "main" 

