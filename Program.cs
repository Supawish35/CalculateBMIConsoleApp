namespace CalculateBMIConsoleApp;

class Program {
    static void Main(string[] args) {
        Console.Clear();
        
        Console.Write("Please enter your height in Centimeters => ");
        float height = float.Parse(Console.ReadLine());
        
        Console.Write("Please enter your weight in Kilograms => ");
        float weight = float.Parse(Console.ReadLine());
        
        double bmi = weight / Math.Pow(height, 2) * 10000 ;
        
        Console.WriteLine($"BMI: {Math.Round(bmi, 2)}");

        if (bmi < 16) {
            Console.WriteLine("Underweight (Severe Thinness)");
        }else if (bmi < 17) {
            Console.WriteLine("Underweight (Moderate Thinness)");
        }else if (bmi < 18.5) {
            Console.WriteLine("Underweight (Mild Thinness)");
        }else if (bmi < 25) {
            Console.WriteLine("Normal");
        }else if (bmi < 30) {
            Console.WriteLine("Overweight");
        }else if (bmi < 35) {
            Console.WriteLine("Obese Class I)");
        }else if (bmi < 40) {
            Console.WriteLine("Obese Class II");
        }else {
            Console.WriteLine("Obese Class III");
        }
    }
}