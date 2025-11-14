using System;

namespace RefactorLabPackage;

public static class ItemController
{
    public static void DecreaseQuality(Item item, int val = 1)
    {
        item.Quality = Math.Max(Constants.MinQuality, item.Quality - val);
    }

    public static void IncreaseQuality(Item item, int val = 1)
    {
        item.Quality = Math.Min(Constants.MaxQuality, item.Quality + val);
    }

    public static void ResetQuality(Item item)
    {
        item.Quality = 0;
    }
    public static void DecreaseSellIn(Item item, int val = 1)
    {
        item.SellIn = item.SellIn - val;
    }

    public static void IncreaseSellIn(Item item, int val = 1)
    {
        item.SellIn = item.SellIn + val;
    }

    public static void ResetSellIn(Item item)
    {
        item.SellIn = 0;
    }
}