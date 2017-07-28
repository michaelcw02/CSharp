namespace FizzBuzz.Library
{
    public class FizzBuzzService {
        public string Print(int n) {
            if(isDivisibleBy(n, 3) && isDivisibleBy(n, 5))  return "FizzBuzz";
            if(isDivisibleBy(n, 3)) return "Fizz";
            if(isDivisibleBy(n, 5)) return "Buzz";
            return n.ToString();
        }
        private bool isDivisibleBy(int n, int d) {
            return n % d == 0;
        }
    }
}