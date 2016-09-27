namespace Web

open WebSharper
open WebSharper.Core.Resources

module Resources =
  type Css() = inherit BaseResource("styles.css")
  type Sortable() = inherit BaseResource(@"paket-files\RubaXa\Sortable\Sortable.min.js")
  type SortableJq() = inherit BaseResource(@"paket-files\RubaXa\Sortable\jquery.binding.js")

  [<assembly:Require(typeof<Css>)>]
  [<assembly:Require(typeof<Sortable>)>]
  [<assembly:Require(typeof<SortableJq>)>]
  do()