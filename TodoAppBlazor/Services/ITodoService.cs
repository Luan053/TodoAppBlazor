namespace TodoAppBlazor.Services
{
    public interface ITodoService
    {
        public void Add(TodoItem item);
        public IEnumerable<TodoItem> GetAll();
    }
}
