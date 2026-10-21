using System;
using System.Collections.Generic;
using System.Text;

namespace adv2
{
    public class Cache<TKey, TValue> where TKey : notnull
    {
        private readonly Dictionary<TKey, (TValue Value, DateTime Expiration)> _store = new();

        public void Add(TKey key, TValue value, TimeSpan timeToLive)
            => _store[key] = (value, DateTime.UtcNow.Add(timeToLive));

        public bool Contains(TKey key)
            => _store.TryGetValue(key, out var item) && item.Expiration > DateTime.UtcNow;

        public TValue Get(TKey key)
            => Contains(key) ? _store[key].Value : throw new KeyNotFoundException("Key  is missing");

        public bool Remove(TKey key)
            => _store.Remove(key);
    }
}
