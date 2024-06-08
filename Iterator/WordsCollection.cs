using System.Collections;

namespace Iterator;

internal class WordsCollection : IteratorAggregate
{
    List<string> _collection = [];

    bool _direction = false;

    public void ReverseDirection()
    {
        _direction = !_direction;
    }

    public List<string> getItems()
    {
        return _collection;
    }

    public void AddItem(string item)
    {
        _collection.Add(item);
    }

    /// <summary>
    /// クライアント側でforeachを使用したときに参照される
    /// </summary>
    public override IEnumerator GetEnumerator()
    {
        return new AlphabeticalOrderIterator(this, _direction);
    }
}
