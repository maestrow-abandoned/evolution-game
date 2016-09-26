namespace Web

open Domain.Types

module Strings =
  let propertyNames = 
    [
      // базовый набор
      (Carnivorous, "Хищник")
      (Swimming, "Водоплавающее")
      (Running, "Быстрое")
      (Mimicry, "Мимикрия")
      (Scavenger, "Падальщик")
      (Symbiosys, "Симбиоз")
      (Piracy, "Пиратство")
      (TailLoss, "Отбрасывание хвоста")
      (Communication, "Взаимодействие")
      (Grazing, "Топотун")
      (HighBodyWeight, "Большое")
      (HibernationAbility, "Спячка")
      (Poisonous, "Ядовитое")
      (Cooperation, "Сотрудничество")
      (Burrowing, "Норное")
      (Camouflage, "Камуфляж")
      (SharpVision, "Острое зрение")
      (FatTissue, "Жировой запас")
      (Parasite, "Паразит")
      // время летать, "")
      (Trematode, "Трематода")
      (Vivaparous, "Живорождение")
      (AmbushHunting, "Засада")
      (Intellect, "Интеллект")
      (Shell, "Раковина")
      (Metamorphose, "Метаморфоза")
      (InkCloud, "Чернильное облако")
      (AnglerFish, "Удильщик")
      (Flight, "Полет")
      (SpecializationA, "Специализация A")
      (SpecializationB, "Специализация B")
      // подарочное издание
      (Flighty, "Пугливое")
      (Homeothermy, "Теплокровность")
      (RStrategy, "r-Стратегия")
      // континенты
      (Cnidocites, "Стрекательные клетки")
      (Regeneration, "Регенерация")
      (Neoplasm, "Неоплазия")
      (Recombination, "Рекомбинация")
      (Aedificator, "Эдификатор")
    ] |> Map.ofList


