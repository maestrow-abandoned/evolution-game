namespace Domain

open WebSharper
open Utils
open Utils.Utils
open Types

[<JavaScript>]
module RandomGameStateGenerator =

  let private rnd = new System.Random()

  let chooseProperty card =
    let order = 
      match card.SecondaryProperty with
      | Some _ -> rnd.Next(0, 1)
      | None -> 0
    { Property.Card = card; Order = [Primary; Secondary].[order] }

  let createAnymal = function 
    | [] -> None
    | baseCard::propCards -> 
        Some { 
          BaseCard = baseCard; 
          Properties = List.map chooseProperty propCards 
        }

  let createAnymalFromDeck (deck: Card list) (propCount: int) =
    let (cards, restDeck) = deck.getFromTop propCount
    (createAnymal cards, restDeck)

  let createPlayer (deck: Card list) =
    let rec loop count deck anymals =
      match count with 
      | 0 -> anymals, deck
      | _ -> 
        match createAnymalFromDeck deck (rnd.Next(1, 6)) with
        | (Some anymal, restDeck) -> loop (count-1) restDeck (anymal::anymals)
        | (None, restDeck) -> anymals, restDeck
    loop (rnd.Next(1, 5)) deck []

  let createPlayersDeck (deck: Card list) =
    let rec loop deck result = function
    | 0 -> result, deck
    | count -> 
      match createPlayer deck with
      | [], restDeck -> result, restDeck
      | (player, restDeck) -> loop restDeck (player::result) (count-1)
    loop deck [] (rnd.Next(2, 8))

  let createGameState (deck: Card list) =
    let (hand, restDeck) = deck.getFromTop 6
    let (players, restDeck) = createPlayersDeck restDeck
    { Hand = hand;
      Players = players;
      CardsDeck = restDeck }