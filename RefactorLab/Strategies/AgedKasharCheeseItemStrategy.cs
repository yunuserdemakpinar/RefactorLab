namespace RefactorLabPackage;

public class AgedKasharCheeseItemStrategy : IItemStrategy
{
    public void UpdateItem(Item item)
    {
        ItemController.DecreaseSellIn(item);
        if (item.SellIn < Constants.SellInThreshold)
            ItemController.IncreaseQuality(item, 2);
        else
            ItemController.IncreaseQuality(item);
    }
}