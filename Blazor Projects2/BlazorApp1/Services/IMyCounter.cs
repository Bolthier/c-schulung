namespace BlazorApp1.Services
{
    public interface IMyCounter
    {
        int Counter { get; }

        void Count();

        event Action CounterChanged;
    }
}