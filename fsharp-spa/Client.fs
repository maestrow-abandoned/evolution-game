namespace EvolutionGame

open WebSharper
open WebSharper.Core.Resources
open WebSharper.JavaScript
open WebSharper.JQuery
open WebSharper.UI.Next
open WebSharper.UI.Next.Html
open WebSharper.UI.Next.Client

module Resources =
  type Css() =
    inherit BaseResource("player.css")

  [<assembly:Require(typeof<Css>)>]
  do()

[<JavaScript>]
module Components =
  let toDoc elm = elm :> Doc

  let createProperty name = 
    divAttr [attr.``class`` "property"] [text name]

  let createAnymal props =
    props 
    |> List.map (createProperty >> toDoc)
    |> divAttr [attr.``class`` "anymal"] 
    
  let createPlayer anymals =
    anymals
    |> List.map (createAnymal >> toDoc)
    |> divAttr [attr.``class`` "player"]

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

