
namespace BlazorApp1.Services
{
    public class MyCounter : IMyCounter
    {
        protected int counter = 0;
        public int Counter => counter;

        public event Action CounterChanged;

        public virtual void Count()
        {
            counter++;
            CounterChanged?.Invoke();
        }
    }
    public class MyCounter2 : MyCounter
    {
        public override void Count()
        {
            for (int i = 0; i < 10; i++)
            {
                base.Count();
            }
        }
    }
    public static class WortmannServiceExtensions
    {
        public static void MeldeCounterAlsScopedServiceAn<T>(this WebApplicationBuilder s) where T : class, IMyCounter
        {
            s.Services.AddScoped<IMyCounter,T>();
        }
    }
}
