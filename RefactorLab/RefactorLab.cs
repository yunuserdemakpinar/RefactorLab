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
            var itemStrategy = ItemStrategyFactory.Create(Items[i].Name);
            itemStrategy.UpdateItem(Items[i]);
        }
    }
}