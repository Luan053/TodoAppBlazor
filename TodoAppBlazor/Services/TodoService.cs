using TodoAppBlazor.Services;
using TodoAppBlazor;

namespace TodoAppBlazor.Services;

public class TodoService : ITodoService
{
    private readonly IList<TodoItem> _todoItems;

    public TodoService()
    {
        _todoItems = new List<TodoItem> {
            new TodoItem("Suas tarefas aparecerão aqui!"),

        };
    }

    public void Add(TodoItem item)
    {
        _todoItems.Add(item);
    }

    public void Delete(TodoItem item)
    {
        _todoItems.Remove(item);
    }


    public IEnumerable<TodoItem> GetAll()
    {
        return _todoItems.ToList();
    }

    public void Remove(TodoItem item)
    {
        _todoItems.Remove(item);
    }

    public void Complete(TodoItem item)
    {
        item.Completed = true;
    }
    public void Uncompletede(TodoItem item)
    {
        item.Completed = false;

    }

}