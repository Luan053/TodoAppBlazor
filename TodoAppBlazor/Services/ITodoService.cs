namespace TodoAppBlazor.Services
{
    public interface ITodoService
    {
        public void Add(TodoItem item);
        public IEnumerable<TodoItem> GetAll();
        public void Delete(TodoItem item);
        public void Complete(TodoItem item);
        public void Uncompletede(TodoItem item);

    }
}
