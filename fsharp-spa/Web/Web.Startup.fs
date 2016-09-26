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

module Resources =
  type Css() =
    inherit BaseResource("player.css")

  [<assembly:Require(typeof<Css>)>]
  do()


module Game =
  
  let private rnd = new System.Random()

  let private getCard deck = function
    | deck::tail -> Some (deck, tail)
    | [] -> None

  let cardDeck = 
    cards
    |> List.collect (fun (pri, sec, count) -> [for i in 1..count -> { PrimaryProperty = pri; SecondaryProperty = sec }]) 
    |> Utils.shuffle

  let createRandomAnymal deck =
    let rec getPropsFromTop count deck props = 
      match count with
      | 0 -> 

      match deck with
      | head::tail -> 
        let newProp = match head.SecondaryProperty with
        | None -> head.PrimaryProperty
        | Some secondaryProp -> 
          match rnd.Next(0, 1) with
          | 0 -> head.PrimaryProperty
          | _ -> head.SecondaryProperty.Value        
        

         Some (deck, tail)
      | [] -> None
      
    for i in 1..rnd.Next(0, 6) -> deck::tail

  let randomPlayer deck =
    for i in 1..rnd.Next(1, 6) -> { Anymal. }


[<JavaScript>]
module Client = 
  let playerState =
    [
      ["хищник";"полет";"водоплавающее"]
      ["теплокровность";"r-стратегия";"норное";"раковина";"жир";"жир"]
      ["ядовитое"]
      ["ядовитое";"теплокровность";"r-стратегия"]
      []
    ]
  
  let Main = 
    playerState
    |> Components.createPlayer 
    |> Doc.RunById "main"

