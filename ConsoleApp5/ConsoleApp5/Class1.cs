
namespace ConsoleApp5
{
    public class СlsCalc<T>
    {
       
        public bool Equal(T value,T value1)
        {
            if (value.Equals(value1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
