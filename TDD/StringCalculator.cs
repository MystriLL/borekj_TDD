namespace TDD;

public class StringCalculator
{
    public int Calculate(string arg)
    {
        var result = 0;
        if (arg.Length > 0)
        {
            var expectedDelimeters = new List<char>();
            expectedDelimeters.Add(',');
            expectedDelimeters.Add('\n');
            
            var arrayOfInputs = arg.Split(expectedDelimeters.ToArray());
            var numbers = new List<int>();

            foreach (var t in arrayOfInputs)
            {
                if (Int32.TryParse(t, out var parsedNumber))
                {
                    if (parsedNumber < 0)
                    {
                        throw new ArgumentException();
                    }

                    if (parsedNumber <= 1000)
                    {
                        numbers.Add(parsedNumber); 
                    }
                }
            }
            result += numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                result += numbers[i];
            }
        }

        return result;
    }
}