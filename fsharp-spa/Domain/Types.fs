namespace Domain

open WebSharper

[<JavaScript>]
module Types = 

  type PropertyType =
    // базовый набор
    | Carnivorous
    | Swimming
    | Running
    | Mimicry
    | Scavenger
    | Symbiosys
    | Piracy
    | TailLoss
    | Communication
    | Grazing
    | HighBodyWeight
    | HibernationAbility
    | Poisonous
    | Cooperation
    | Burrowing
    | Camouflage
    | SharpVision
    | FatTissue
    | Parasite
    // время летать
    | Trematode
    | Vivaparous
    | AmbushHunting
    | Intellect
    | Shell
    | Metamorphose
    | InkCloud
    | AnglerFish
    | Flight
    | SpecializationA
    | SpecializationB
    // подарочное издание
    | Flighty
    | Homeothermy
    | RStrategy
    // континенты
    | Cnidocites
    | Regeneration
    | Neoplasm
    | Recombination
    | Aedificator
    //| Migrations
    //| Suckerfish
    //| Herding



  [<System.Flags>]
  type CanBePlayedOn = Self = 1 | Enemy = 2

  type PropertyFeatures = {
    FoodDemand: int;
    CanBePlayedOn: CanBePlayedOn;
    IsPair: bool;
    // Description: string;
  }

  /// Карточка в игровом наборе
  type Card = {
    PrimaryProperty: PropertyType;
    SecondaryProperty: Option<PropertyType>;
  }

  type GameState = {
    Hand: 
  }
