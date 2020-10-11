using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace country_names.Extension
{
    public static class IEnumerableExtensions
    {
        public static async Task<ObservableCollection<T>> ToObservableCollectionAsync<T>(this Task<IEnumerable<T>> source)
        {
            ObservableCollection<T> collection = new ObservableCollection<T>();

            foreach (T item in await source)
            {
                collection.Add(item);
            }

            return collection;
        }
    }
}
