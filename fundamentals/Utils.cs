using System.Linq;
namespace fundamentals
{
    public class Utils
    {
        public static int Sum(params int[] values)
        {
            return values.Sum();
        }
    }
}