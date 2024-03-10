using TRPO_Lab3.Lib;

double a = 0;
double h = 0;

void print(string str)
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.Write(str);
    Console.ForegroundColor = ConsoleColor.White;
};

double take()
{
    double param = Convert.ToDouble(Console.ReadLine());
    return param;
}

print("- The volume of a regular quadrangular pyramid - \n\n");

print("Enter the length: ");
a = take();

print("Enter the height: ");
h = take();

print("\n");

double result = Math.Round(FormulaLib.Pyramid_Reg4_Volume(a, h), 3);
print("Result: ");
print(Convert.ToString(result));
print("\n");