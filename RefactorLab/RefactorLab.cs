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
            if (Items[i].Name != "Eski Kaşar Peyniri" && Items[i].Name != "Bulutsuzluk özlemi konser bileti")
            {
                if (Items[i].Quality > Constants.MinQuality)
                {
                    if (Items[i].Name != "Sebze meyve")
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

                    if (Items[i].Name == "Bulutsuzluk özlemi konser bileti")
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

            if (Items[i].Name != "Sebze meyve")
            {
                Items[i].SellIn = Items[i].SellIn - 1;
            }

            if (Items[i].SellIn < Constants.SellInThreshold)
            {
                if (Items[i].Name != "Eski Kaşar Peyniri")
                {
                    if (Items[i].Name != "Bulutsuzluk özlemi konser bileti")
                    {
                        if (Items[i].Quality > Constants.MinQuality)
                        {
                            if (Items[i].Name != "Sebze meyve")
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