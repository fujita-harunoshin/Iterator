using System.Collections;

namespace Iterator;

abstract class IteratorAggregate : IEnumerable
{
    public abstract IEnumerator GetEnumerator();
}
