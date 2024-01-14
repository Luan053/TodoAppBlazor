using TodoAppBlazor.Services;
using TodoAppBlazor;

namespace TodoAppBlazor.Services;

public class TodoService : ITodoService
{
    private readonly IList<TodoItem> _todoItems;

    public TodoService()
    {
        _todoItems = new List<TodoItem> {
            new TodoItem("Dobrar Roupas"),
            new TodoItem("Estudar C#"),
            new TodoItem("Treino")

        };
    }

    public void Add(TodoItem item)
    {
        _todoItems.Add(item);
    }

    public IEnumerable<TodoItem> GetAll()
    {
        return _todoItems.ToList();
    }
}