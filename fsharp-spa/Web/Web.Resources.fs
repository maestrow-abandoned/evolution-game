namespace Web

open WebSharper
open WebSharper.Core.Resources

module Resources =
  type Css() =
    inherit BaseResource("player.css")

  [<assembly:Require(typeof<Css>)>]
  do()