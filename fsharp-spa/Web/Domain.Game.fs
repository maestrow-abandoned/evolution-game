namespace Domain

open WebSharper

open Utils
open Utils.Utils
open Types
open Configuration

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