namespace RefactorLabPackage;

public static class ItemNameConverter
{
    public static ItemName StringToItemName(string name)
    {
        return name switch
        {
            "Eski Kaşar Peyniri" => ItemName.AgedKasharCheese,
            "Bulutsuzluk özlemi konser bileti" => ItemName.BulutusuzlukOzlemiConcertTicket,
            "Sebze meyve" => ItemName.VegetableOrFruit,
            _ => ItemName.Other
        };
    }
}