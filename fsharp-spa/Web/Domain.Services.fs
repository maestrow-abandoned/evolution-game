namespace Domain

open WebSharper

open Utils
open Utils.Utils
open Types
open ConfigurationData

[<JavaScript>]
module Services =
  
  let fullDeck = 
    cards
    |> List.collect (fun (pri, sec, count) -> [for i in 1..count -> { PrimaryProperty = pri; SecondaryProperty = sec }]) 
    |> Utils.shuffle


