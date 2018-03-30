namespace Web

open WebSharper
open WebSharper.UI.Next
open WebSharper.UI.Next.Html
open WebSharper.UI.Next.Client

open Domain.Types
open Domain.Strings

[<JavaScript>]
module Components =
  let private toDoc elm = elm :> Doc

  let createProperty (prop: PropertyType) = 
    divAttr [attr.``class`` "property"] [text propertyNames.[prop]]

  let createAnymal (anymal: Anymal) =
    anymal.Properties 
    |> List.map (fun p -> p.Value)
    |> List.map (createProperty >> toDoc)
    |> divAttr [attr.``class`` "anymal"] 
    
  let createPlayer (anymals: Player) =
    anymals
    |> List.map (createAnymal >> toDoc)
    |> divAttr [attr.``class`` "player"]

  let createPlayersDeck (players: Player list) = 
    players
    |> List.map (createPlayer >> toDoc)
    |> divAttr [attr.``class`` "players"]

  let createCard (card: Card) = 
    match card.SecondaryProperty with
    | None -> [card.PrimaryProperty]
    | Some secondary -> [card.PrimaryProperty; secondary]
    |> List.map (createProperty >> toDoc)
    |> divAttr [attr.``class`` "card"]

  let createHand (cards: Card list) =
    cards
    |> List.map (createCard >> toDoc)
    |> divAttr [attr.``class`` "hand"]

  let createGameView (game: GameState) = 
    divAttr [attr.``class`` "game-view"] [
      createHand game.Hand
      div [
        divAttr [attr.``class`` "food"] [text "еда"]
        createPlayersDeck game.Players
      ]
    ]