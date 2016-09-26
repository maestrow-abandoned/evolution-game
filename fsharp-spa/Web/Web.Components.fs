namespace Web

open WebSharper
open WebSharper.UI.Next
open WebSharper.UI.Next.Html
open WebSharper.UI.Next.Client

open Domain.Types
open Web.Strings

[<JavaScript>]
module Components =
  let toDoc elm = elm :> Doc

  let createProperty (prop: Property) = 
    divAttr [attr.``class`` "property"] [text propertyNames.[prop.Value]]

  let createAnymal (anymal: Anymal) =
    anymal.Properties 
    |> List.map (createProperty >> toDoc)
    |> divAttr [attr.``class`` "anymal"] 
    
  let createPlayer (anymals: Anymal list) =
    anymals
    |> List.map (createAnymal >> toDoc)
    |> divAttr [attr.``class`` "player"] 