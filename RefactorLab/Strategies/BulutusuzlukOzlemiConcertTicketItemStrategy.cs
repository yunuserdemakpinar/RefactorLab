namespace RefactorLabPackage;

public class BulutusuzlukOzlemiConcertTicketItemStrategy : IItemStrategy
{
    public void UpdateItem(Item item)
    {
        if (item.SellIn - 1 < Constants.SellInThreshold)
        {
            ItemController.ResetQuality(item);
            ItemController.DecreaseSellIn(item);
        }
        else
        {
            if (item.SellIn < Constants.ConcertTicketSellInThreshold2)
                ItemController.IncreaseQuality(item, 3);
            else if (item.SellIn < Constants.ConcertTicketSellInThreshold1)
                ItemController.IncreaseQuality(item, 2);
            else
                ItemController.IncreaseQuality(item);

            ItemController.DecreaseSellIn(item);
        }
    }
}