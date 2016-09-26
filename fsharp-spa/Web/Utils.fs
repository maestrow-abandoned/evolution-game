namespace Utils

open System
open WebSharper

[<JavaScript>]
module Utils = 
  
  let private random = new Random()
  
  let getRandomInts max =
    [ for i in 0..max -> (i, random.NextDouble()) ]
    |> List.sortBy (fun (_, rnd) -> rnd) 
    |> List.map (fun (i, _) -> i)

  let shuffle lst =
    lst
    |> List.map (fun i -> i, random.NextDouble())
    |> List.sortBy (fun (_, rnd) -> rnd) 
    |> List.map (fun (i, _) -> i)

  type List<'a> with
    member private this.loop count src result = 
      match count with
      | 0 -> result, src
      | _ -> 
        match src with
        | head::tail -> this.loop (count-1) tail (head::result)
        | [] -> result, src
    member this.getFromTop count =
      this.loop count this []