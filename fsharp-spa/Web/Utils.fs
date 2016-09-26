namespace Utils

open System
//open WebSharper

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