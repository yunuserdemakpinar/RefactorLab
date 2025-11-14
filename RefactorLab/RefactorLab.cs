using System.Collections.Generic;

namespace RefactorLabKata;

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
                if (Items[i].Quality > 0)
                {
                    if (Items[i].Name != "Sebze meyve")
                    {
                        Items[i].Quality = Items[i].Quality - 1;
                    }
                }
            }
            else
            {
                if (Items[i].Quality < 50)
                {
                    Items[i].Quality = Items[i].Quality + 1;

                    if (Items[i].Name == "Bulutsuzluk özlemi konser bileti")
                    {
                        if (Items[i].SellIn < 11)
                        {
                            if (Items[i].Quality < 50)
                            {
                                Items[i].Quality = Items[i].Quality + 1;
                            }
                        }

                        if (Items[i].SellIn < 6)
                        {
                            if (Items[i].Quality < 50)
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

            if (Items[i].SellIn < 0)
            {
                if (Items[i].Name != "Eski Kaşar Peyniri")
                {
                    if (Items[i].Name != "Bulutsuzluk özlemi konser bileti")
                    {
                        if (Items[i].Quality > 0)
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
                    if (Items[i].Quality < 50)
                    {
                        Items[i].Quality = Items[i].Quality + 1;
                    }
                }
            }
        }
    }
}