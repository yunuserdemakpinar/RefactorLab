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
                if (Items[i].Quality > Constants.MinQuality)
                {
                    if (itemName != ItemName.VegetableOrFruit)
                    {
                        Items[i].Quality = Items[i].Quality - 1;
                    }
                }
            }
            else
            {
                if (Items[i].Quality < Constants.MaxQuality)
                {
                    Items[i].Quality = Items[i].Quality + 1;

                    if (itemName == ItemName.BulutusuzlukOzlemiConcertTicket)
                    {
                        if (Items[i].SellIn < Constants.ConcertTicketSellInThreshold1)
                        {
                            if (Items[i].Quality < Constants.MaxQuality)
                            {
                                Items[i].Quality = Items[i].Quality + 1;
                            }
                        }

                        if (Items[i].SellIn < Constants.ConcertTicketSellInThreshold2)
                        {
                            if (Items[i].Quality < Constants.MaxQuality)
                            {
                                Items[i].Quality = Items[i].Quality + 1;
                            }
                        }
                    }
                }
            }

            if (itemName != ItemName.VegetableOrFruit)
            {
                Items[i].SellIn = Items[i].SellIn - 1;
            }

            if (Items[i].SellIn < Constants.SellInThreshold)
            {
                if (itemName != ItemName.AgedKasharCheese)
                {
                    if (itemName != ItemName.BulutusuzlukOzlemiConcertTicket)
                    {
                        if (Items[i].Quality > Constants.MinQuality)
                        {
                            if (itemName != ItemName.VegetableOrFruit)
                            {
                                Items[i].Quality = Items[i].Quality - 1;
                            }
                        }
                    }
                    else
                    {
                        Items[i].Quality = Items[i].Quality - Items[i].Quality;
                    }
                }
                else
                {
                    if (Items[i].Quality < Constants.MaxQuality)
                    {
                        Items[i].Quality = Items[i].Quality + 1;
                    }
                }
            }
        }
    }
}