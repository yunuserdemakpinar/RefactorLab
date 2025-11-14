namespace RefactorLabPackage;

// Since I believe this mode comes from a place like a database or a endpoint, I'm refactoring the code without changing it at all.
public class Item
{
    public string Name { get; set; }
    public int SellIn { get; set; }
    public int Quality { get; set; }
}