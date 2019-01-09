using System.Threading.Tasks;

namespace AWSDemoApplication
{
    public class BMIApi
    {
        public static Task<float> CalculateBMI(int weight, int height)
        {
            return Task.FromResult(weight / (((float) height / 100) * ((float) height / 100)));
        }
    }
}