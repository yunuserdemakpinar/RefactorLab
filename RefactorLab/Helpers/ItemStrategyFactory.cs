namespace RefactorLabPackage;

public static class ItemStrategyFactory
{
    public static IItemStrategy Create(string itemName)
    {
        return itemName switch
        {
            "Eski Kaşar Peyniri" => new AgedKasharCheeseItemStrategy(),
            "Bulutsuzluk özlemi konser bileti" => new BulutusuzlukOzlemiConcertTicketItemStrategy(),
            "Sebze meyve" => new VegetableOrFruitItemStrategy(),
            _ => new OtherItemStrategy()
        };
    }
}