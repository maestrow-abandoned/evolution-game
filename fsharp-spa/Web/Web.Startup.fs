namespace Web

open WebSharper
open WebSharper.Core.Resources
open WebSharper.JavaScript
open WebSharper.JQuery
open WebSharper.UI.Next
open WebSharper.UI.Next.Html
open WebSharper.UI.Next.Client

open Domain.Types
open Domain.Configuration
open Components
open Utils
open Utils.Utils

module Resources =
  type Css() =
    inherit BaseResource("player.css")

  [<assembly:Require(typeof<Css>)>]
  do()

[<JavaScript>]
module Game =
  
  let private rnd = new System.Random()

  let fullDeck = 
    cards
    |> List.collect (fun (pri, sec, count) -> [for i in 1..count -> { PrimaryProperty = pri; SecondaryProperty = sec }]) 
    |> Utils.shuffle

  let chooseRandomProperty card =
    let order = 
      match card.SecondaryProperty with
      | Some _ -> rnd.Next(0, 1)
      | None -> 0
    { Property.Card = card; Order = [Primary; Secondary].[order] }

  let createRandomAnymal = function 
    | [] -> None
    | baseCard::propCards -> 
        Some { 
          BaseCard = baseCard; 
          Properties = List.map chooseRandomProperty propCards 
        }

  let createRandomAnymalFromDeck (deck: Card list) (propCount: int) =
    let (cards, restDeck) = deck.getFromTop propCount
    (createRandomAnymal cards, restDeck)

  let createRandomPlayer deck =
    let rec loop count deck anymals =
      match count with 
      | 0 -> anymals, deck
      | _ -> 
        match createRandomAnymalFromDeck deck (rnd.Next(1, 6)) with
        | (Some anymal, restDeck) -> loop (count-1) restDeck (anymal::anymals)
        | (None, restDeck) -> anymals, restDeck
    loop (rnd.Next(1, 5)) deck []

[<JavaScript>]
module Client = 
  let player = fst (Game.createRandomPlayer Game.fullDeck)
  let Main = 
    player
    |> Components.createPlayer 
    |> Doc.RunById "main" 

