using System;

namespace RefactorLabPackage;

public static class ItemController
{
    public static void DecreaseQuality(Item item)
    {
        item.Quality = Math.Max(Constants.MinQuality, item.Quality - 1);
    }

    public static void IncreaseQuality(Item item)
    {
        item.Quality = Math.Min(Constants.MaxQuality, item.Quality + 1);
    }

    public static void ResetQuality(Item item)
    {
        item.Quality = 0;
    }
    public static void DecreaseSellIn(Item item)
    {
        item.SellIn = item.SellIn - 1;
    }

    public static void IncreaseSellIn(Item item)
    {
        item.SellIn = item.SellIn + 1;
    }

    public static void ResetSellIn(Item item)
    {
        item.SellIn = 0;
    }
}