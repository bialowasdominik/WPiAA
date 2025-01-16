using System.Collections.Generic;

namespace GildedRoseKata;

public class GildedRose
{
    private readonly Dictionary<string, IItemStrategy> _strategies;
    private IList<Item> items;
    public GildedRose(IList<Item> items)
    {
        this.items = items;
        // Initialize the strategies dictionary
        _strategies = new Dictionary<string, IItemStrategy>
        {
            { "Aged Brie", new AgedBrieStrategy() },
            { "Backstage passes to a TAFKAL80ETC concert", new BackstagePassesStrategy() },
            { "Sulfuras, Hand of Ragnaros", new SulfurasStrategy() },
        };
    }

    public void UpdateQuality()
    {
        foreach (var item in items)
        {
            IItemStrategy strategy;

            if (_strategies.TryGetValue(item.Name, out strategy))
            {
                strategy.Update(item);
            }
            else
            {
                new NormalItemStrategy().Update(item);
            }
        }
    }
}