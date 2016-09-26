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

  type PropertyOrder = Primary | Secondary 

  /// Карточка в игровом наборе
  type Card = {
    PrimaryProperty: PropertyType;
    SecondaryProperty: Option<PropertyType>;
  }

  exception InvalidPropertyError

  /// Карточка, сыгранная как свойство
  type Property = {
    Card: Card
    Order: PropertyOrder
  } with
    member this.Validate () =
      if this.Order = Secondary && this.Card.SecondaryProperty.IsNone then raise InvalidPropertyError
    member this.Value = 
      this.Validate()
      match this.Order with
      | Primary -> this.Card.PrimaryProperty
      | Secondary -> this.Card.SecondaryProperty.Value

  type Anymal = {
    BaseCard: Card
    Properties: Property list
  }

  type Player = Anymal list

  type GameState = {
    Hand: Card list
    Players: Player list
    CardsDeck: Card list
  }
