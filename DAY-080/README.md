# DAY-080:

## Other useful function in List collection class:

- `TrueForAll()`: returns true or false depending on whether if every element in the list matches the conditions defined by the specified predicate.

- `AsReadOnly()`: returns a read-only wrapper for the current collection. Use this method, if you don't want the client code to modify the collection, i.e. add or remove any elements from the collecton. The ReadOnlyCollection will not have methods to add or remove items from the collection. You can only read items from this collection.

- `TrimExcess()`: sets the capacity to the actual number of elements in the list, if that number is less than a threshold value.

*Note: TrimExcess() method can be used to minimize a collection's memory overhead if no new elements will be added to the collection. The cost of reallocating and copying a large List<T> can be considerable. So the TrimExcess() method does nothing if the list is at more than 90 percent of capacity. This avoids incurring a large reallocation cost for a relatively small gain. The current threshold is 90 percent, but could change in the future.*