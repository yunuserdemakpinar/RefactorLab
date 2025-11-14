namespace RefactorLabPackage;

public class OtherItemStrategy : IItemStrategy
{
    public void UpdateItem(Item item)
    {
        ItemController.DecreaseSellIn(item);
        if (item.SellIn < Constants.SellInThreshold)
            ItemController.DecreaseQuality(item, 2);
        else
            ItemController.DecreaseQuality(item);
    }
}