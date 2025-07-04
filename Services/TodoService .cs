namespace ToDoWebApi.Services
{
    public class TodoService : ITodoService
    {
        private readonly List<string> _items = new();
        public IEnumerable<string> GetAll() => _items;
        public void Add(string item) => _items.Add(item);
    }
}
