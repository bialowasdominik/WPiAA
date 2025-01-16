namespace GildedRoseKata;

public class Item
{
    public string Name { get; set; }
    public int SellIn { get; set; }
    public int Quality { get; set; }
}

public interface IItemStrategy
{
    void Update(Item item);
}

public class NormalItemStrategy : IItemStrategy
{
    public void Update(Item item)
    {
        if (item.Quality > 0)
        {
            item.Quality--;
        }
        item.SellIn--;

        if (item.SellIn < 0 && item.Quality > 0)
        {
            item.Quality--;
        }
    }
}

public class AgedBrieStrategy : IItemStrategy
{
    public void Update(Item item)
    {
        if (item.Quality < 50)
        {
            item.Quality++;
        }
        item.SellIn--;
    }
}

public class BackstagePassesStrategy : IItemStrategy
{
    public void Update(Item item)
    {
        if (item.Quality < 50)
        {
            item.Quality++;

            if (item.SellIn < 11)
            {
                item.Quality++;
            }
            if (item.SellIn < 6)
            {
                item.Quality++;
            }
        }

        item.SellIn--;

        if (item.SellIn < 0)
        {
            item.Quality = 0;
        }
    }
}

public class SulfurasStrategy : IItemStrategy
{
    public void Update(Item item)
    {
    }
}
