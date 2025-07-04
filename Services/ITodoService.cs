namespace ToDoWebApi.Services
{
    public interface ITodoService
    {
        IEnumerable<string> GetAll();
        void Add(string item);
    }
}
