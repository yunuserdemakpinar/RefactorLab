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

            if (itemName != ItemName.AgedKasharCheese && itemName != ItemName.BulutusuzlukOzlemiConcertTicket)
            {
                if (itemName != ItemName.VegetableOrFruit)
                    ItemController.DecreaseQuality(Items[i]);
            }
            else
            {
                ItemController.IncreaseQuality(Items[i]);

                if (itemName == ItemName.BulutusuzlukOzlemiConcertTicket)
                {
                    if (Items[i].SellIn < Constants.ConcertTicketSellInThreshold1)
                        ItemController.IncreaseQuality(Items[i]);

                    if (Items[i].SellIn < Constants.ConcertTicketSellInThreshold2)
                        ItemController.IncreaseQuality(Items[i]);
                }
            }

            if (itemName != ItemName.VegetableOrFruit)
                ItemController.DecreaseSellIn(Items[i]);

            if (Items[i].SellIn < Constants.SellInThreshold)
            {
                if (itemName != ItemName.AgedKasharCheese)
                {
                    if (itemName != ItemName.BulutusuzlukOzlemiConcertTicket)
                    {
                        if (itemName != ItemName.VegetableOrFruit)
                            ItemController.DecreaseQuality(Items[i]);
                    }
                    else
                        ItemController.ResetQuality(Items[i]);
                }
                else
                    ItemController.IncreaseQuality(Items[i]);
            }
        }
    }
}