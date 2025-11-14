using System.Collections.Generic;

namespace RefactorLabPackage;

public class RefactorLab
{
    IList<Item> Items;

    public RefactorLab(IList<Item> Items)
    {
        this.Items = Items;
    }

    public void UpdateQuality()
    {
        for (var i = 0; i < Items.Count; i++)
        {
            var itemName = ItemNameConverter.StringToItemName(Items[i].Name);

            if (itemName == ItemName.VegetableOrFruit)
                continue;

            switch (itemName)
            {
                case ItemName.BulutusuzlukOzlemiConcertTicket:
                    if (Items[i].SellIn < Constants.ConcertTicketSellInThreshold2)
                        ItemController.IncreaseQuality(Items[i], 3);
                    else if (Items[i].SellIn < Constants.ConcertTicketSellInThreshold1)
                        ItemController.IncreaseQuality(Items[i], 2);
                    else
                        ItemController.IncreaseQuality(Items[i]);
                    break;
                case ItemName.AgedKasharCheese:
                    ItemController.IncreaseQuality(Items[i]);
                    break;
                default:
                    ItemController.DecreaseQuality(Items[i]);
                    break;
            }

            ItemController.DecreaseSellIn(Items[i]);

            if (Items[i].SellIn < Constants.SellInThreshold)
            {
                switch (itemName)
                {
                    case ItemName.BulutusuzlukOzlemiConcertTicket:
                        ItemController.ResetQuality(Items[i]);
                        break;
                    case ItemName.AgedKasharCheese:
                        ItemController.IncreaseQuality(Items[i]);
                        break;
                    default:
                        ItemController.DecreaseQuality(Items[i]);
                        break;
                }
            }
        }
    }
}