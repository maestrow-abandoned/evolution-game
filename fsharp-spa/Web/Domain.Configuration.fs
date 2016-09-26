namespace Domain

open WebSharper
open Types

[<JavaScript>]
module Configuration =

  let features = [
    (Carnivorous, { 
      FoodDemand = 1; 
      CanBePlayedOn = CanBePlayedOn.Self; 
      IsPair = false; })
    (Swimming, { 
      FoodDemand = 0; 
      CanBePlayedOn = CanBePlayedOn.Self; 
      IsPair = false; })
    (Running, { 
      FoodDemand = 0; 
      CanBePlayedOn = CanBePlayedOn.Self; 
      IsPair = false; })
    (Mimicry, { 
      FoodDemand = 0; 
      CanBePlayedOn = CanBePlayedOn.Self; 
      IsPair = false; })
    (Scavenger, { 
      FoodDemand = 0; 
      CanBePlayedOn = CanBePlayedOn.Self; 
      IsPair = false; })
    (Symbiosys, { 
      FoodDemand = 0; 
      CanBePlayedOn = CanBePlayedOn.Self; 
      IsPair = true; })
    (Piracy, { 
      FoodDemand = 0; 
      CanBePlayedOn = CanBePlayedOn.Self; 
      IsPair = false; })
    (TailLoss, { 
      FoodDemand = 0; 
      CanBePlayedOn = CanBePlayedOn.Self; 
      IsPair = false; })
    (Communication, { 
      FoodDemand = 0; 
      CanBePlayedOn = CanBePlayedOn.Self; 
      IsPair = true; })
    (Grazing, { 
      FoodDemand = 0; 
      CanBePlayedOn = CanBePlayedOn.Self; 
      IsPair = false; })
    (HighBodyWeight, { 
      FoodDemand = 1; 
      CanBePlayedOn = CanBePlayedOn.Self; 
      IsPair = false; })
    (HibernationAbility, { 
      FoodDemand = 0; 
      CanBePlayedOn = CanBePlayedOn.Self; 
      IsPair = false; })
    (Poisonous, { 
      FoodDemand = 0; 
      CanBePlayedOn = CanBePlayedOn.Self; 
      IsPair = false; })
    (Cooperation, { 
      FoodDemand = 0; 
      CanBePlayedOn = CanBePlayedOn.Self; 
      IsPair = true; })
    (Burrowing, { 
      FoodDemand = 0; 
      CanBePlayedOn = CanBePlayedOn.Self; 
      IsPair = false; })
    (Camouflage, { 
      FoodDemand = 0; 
      CanBePlayedOn = CanBePlayedOn.Self; 
      IsPair = false; })
    (SharpVision, { 
      FoodDemand = 0; 
      CanBePlayedOn = CanBePlayedOn.Self; 
      IsPair = false; })
    (FatTissue, { 
      FoodDemand = 0; 
      CanBePlayedOn = CanBePlayedOn.Self; 
      IsPair = false; })
    (Parasite, { 
      FoodDemand = 2; 
      CanBePlayedOn = CanBePlayedOn.Enemy; 
      IsPair = false; })
    (Trematode, { 
      FoodDemand = 1; 
      CanBePlayedOn = CanBePlayedOn.Enemy; 
      IsPair = true; })
    (Vivaparous, { 
      FoodDemand = 1; 
      CanBePlayedOn = CanBePlayedOn.Self; 
      IsPair = false; })
    (AmbushHunting, { 
      FoodDemand = 0; 
      CanBePlayedOn = CanBePlayedOn.Self; 
      IsPair = false; })
    (Intellect, { 
      FoodDemand = 1; 
      CanBePlayedOn = CanBePlayedOn.Self; 
      IsPair = false; })
    (Shell, { 
      FoodDemand = 0; 
      CanBePlayedOn = CanBePlayedOn.Self; 
      IsPair = false; })
    (Metamorphose, { 
      FoodDemand = 0; 
      CanBePlayedOn = CanBePlayedOn.Self; 
      IsPair = false; })
    (InkCloud, { 
      FoodDemand = 0; 
      CanBePlayedOn = CanBePlayedOn.Self; 
      IsPair = false; })
    (AnglerFish, {  // хищник-удильник как свойство может быть сыгран только как хищник
      FoodDemand = 1; 
      CanBePlayedOn = CanBePlayedOn.Self; 
      IsPair = false; })
    (Flight, { 
      FoodDemand = 0; 
      CanBePlayedOn = CanBePlayedOn.Self; 
      IsPair = false; })
    (Flighty, { 
      FoodDemand = 0; 
      CanBePlayedOn = CanBePlayedOn.Self; 
      IsPair = false; })
    (Homeothermy, { 
      FoodDemand = 1; 
      CanBePlayedOn = CanBePlayedOn.Self; 
      IsPair = false; })
    (RStrategy, { 
      FoodDemand = 0; 
      CanBePlayedOn = CanBePlayedOn.Self ||| CanBePlayedOn.Enemy; 
      IsPair = false; })
    (Cnidocites, {  
      FoodDemand = 0; 
      CanBePlayedOn = CanBePlayedOn.Self; 
      IsPair = false; })
    (Regeneration, { 
      FoodDemand = 0; 
      CanBePlayedOn = CanBePlayedOn.Self; 
      IsPair = false; })
    (Neoplasm, { 
      FoodDemand = 0; 
      CanBePlayedOn = CanBePlayedOn.Enemy; 
      IsPair = false; })
    (Recombination, { 
      FoodDemand = 0; 
      CanBePlayedOn = CanBePlayedOn.Self; 
      IsPair = true; })
    (Aedificator, { 
      FoodDemand = 0; 
      CanBePlayedOn = CanBePlayedOn.Self; 
      IsPair = false; })
    (SpecializationA, {
      FoodDemand = 0
      CanBePlayedOn = CanBePlayedOn.Self
      IsPair = false})
    (SpecializationB, {
      FoodDemand = 0
      CanBePlayedOn = CanBePlayedOn.Self
      IsPair = false})
  ] 

  let cards = [
    // Cards with single properties
    (Scavenger, None, 4)
    (Mimicry, None, 4)
    (Swimming, None, 8)
    (InkCloud, None, 4)
    (Running, None, 4)
    (RStrategy, None, 6)
    (Piracy, None, 4)
    (Shell, None, 4)
    (Symbiosys, None, 4)
    (TailLoss, None, 4)
    
    // Cards with quantity of 4
    (AnglerFish, Some Carnivorous, 4)
    (Communication, Some Carnivorous, 4)
    (Cooperation, Some Carnivorous, 4)
    (Parasite, Some Carnivorous, 4)
    (HibernationAbility, Some Carnivorous, 4)
    (Grazing, Some FatTissue, 4)
    (HighBodyWeight, Some Carnivorous, 4)
    (Trematode, Some Cooperation, 4)
    (Parasite, Some FatTissue, 4)
    (Camouflage, Some FatTissue, 4)
    (SharpVision, Some FatTissue, 4)
    (HighBodyWeight, Some FatTissue, 4)
    (Poisonous, Some Carnivorous, 4)
    (Cooperation, Some FatTissue, 4)
    (Burrowing, Some FatTissue, 4)

    // Cards with quantity of 2
    (Regeneration, Some Carnivorous, 2)
    (Regeneration, Some Cooperation, 2)
    (Regeneration, Some Swimming, 2)
    (Homeothermy, Some Swimming, 2)
    (Homeothermy, Some FatTissue, 2)
    (Homeothermy, Some Carnivorous, 2)
    (Flight, Some SpecializationA, 2)
    (Flight, Some SpecializationB, 2)
    (Flight, Some Carnivorous, 2)
    (Flighty, Some FatTissue, 2)
    (Flighty, Some Swimming, 2)
    (Flighty, Some Carnivorous, 2)

    (Aedificator, Some Swimming, 2)
    (Aedificator, Some Carnivorous, 2)
    (AmbushHunting, Some Swimming, 2)
    (AmbushHunting, Some SpecializationB, 2)
    (Neoplasm, Some Communication, 2)
    (Neoplasm, Some Swimming, 2)
    (Intellect, Some FatTissue, 2)
    (Intellect, Some SpecializationA, 2)
    (Vivaparous, Some SpecializationB, 2)
    (Vivaparous, Some Swimming, 2)
    (Trematode, Some Communication, 2)
    (Trematode, Some FatTissue, 2)
    (Recombination, Some Carnivorous, 2)
    (Recombination, Some Swimming, 2)
    (Metamorphose, Some Carnivorous, 2)
    (Metamorphose, Some SpecializationA, 2)
    (Cnidocites, Some Swimming, 2)
    (Cnidocites, Some Communication, 2)
  ]