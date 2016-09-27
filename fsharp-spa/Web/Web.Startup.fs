namespace Web

open WebSharper
open WebSharper.Core.Resources
open WebSharper.JavaScript
open WebSharper.JQuery
open WebSharper.UI.Next
open WebSharper.UI.Next.Html
open WebSharper.UI.Next.Client

open Domain
open Domain.Types
open Domain.Configuration
open Components
open Utils
open Utils.Utils

[<JavaScript>]
module Client = 
  let player = fst (Game.createRandomPlayer Game.fullDeck)
  let Main = 
    player
    |> Components.createPlayer 
    |> Doc.RunById "main" 

