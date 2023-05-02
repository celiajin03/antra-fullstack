// A GenericRepository<T> class that implements IRepository<T> interface with common /CRUD/ operations

using GenericRepo;

class GenericRepository<T> : IRepository<T> where T : Entity
{
    List<T> list = new List<T>();

    public void Add(T item)
    {
        list.Add(item);
    }

    public IEnumerable<T> GetAll()
    {
        return list;
    }

    public T GetById(int id)
    {
        foreach (var item in list)
        {
            if (item.Id == id) return item;
        }
        throw new InvalidOperationException("Item not found");
    }

    public void Remove(T item)
    {
        list.Remove(item);
    }

    public void Save()
    {
        throw new NotImplementedException();
    }
}


class Entity
{
    public int Id { get; set; }
}