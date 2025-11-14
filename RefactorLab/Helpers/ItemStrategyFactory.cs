namespace RefactorLabPackage;

public static class ItemStrategyFactory
{
    public static IItemStrategy Create(ItemName itemName)
    {
        return itemName switch
        {
            ItemName.AgedKasharCheese => new AgedKasharCheeseItemStrategy(),
            ItemName.BulutusuzlukOzlemiConcertTicket => new BulutusuzlukOzlemiConcertTicketItemStrategy(),
            ItemName.VegetableOrFruit => new VegetableOrFruitItemStrategy(),
            _ => new OtherItemStrategy()
        };
    }
}