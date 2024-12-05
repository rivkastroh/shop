﻿

using DO;

namespace DalApi;

public interface ICRUD<T>
{
    int Create(T item);
    T Read(int id);
    T? Read(Func<T,bool> filter);
    List<T?> ReadAll(Func<T,bool>? filter = null);
    void Update(T item);
    void Delete(int id);
}
