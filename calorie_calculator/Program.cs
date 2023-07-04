void Calculator(float massa, float protein, float fat, float carbohydrate, float calorie)
{
    Console.WriteLine("Введите массу блюда:");
    float m = Convert.ToInt32(Console.ReadLine());
    massa += m;
    Console.WriteLine("Введите процент содержания белка:");
    protein += Convert.ToSingle(Console.ReadLine()) * m / 100;
    Console.WriteLine("Введите процент содержания жира:");
    fat += Convert.ToSingle(Console.ReadLine()) * m / 100;
    Console.WriteLine("Введите процент содержания углеводов:");
    carbohydrate += Convert.ToSingle(Console.ReadLine()) * m / 100; // углевод
    Console.WriteLine("Введите колорийность 100грамм данного блюда");
    calorie = Convert.ToSingle(Console.ReadLine()) * m / 100;

    File.WriteAllText("/Users/lukakocegov/RiderProjects/calorie_calculator/report.txt",
        $"сегодня съедено {massa} грамм еды{Environment.NewLine}из них:{Environment.NewLine}{protein} грамм белка{Environment.NewLine}{fat} грамм жира{Environment.NewLine}{carbohydrate} грамм углеводов{Environment.NewLine}все это дало {calorie} ккалорий");

    //обновим вспомогательные файлы 
    File.WriteAllText("/Users/lukakocegov/RiderProjects/calorie_calculator/data/massa.txt", $"{massa}");
    File.WriteAllText("/Users/lukakocegov/RiderProjects/calorie_calculator/data/protein.txt", $"{protein}");
    File.WriteAllText("/Users/lukakocegov/RiderProjects/calorie_calculator/data/fat.txt", $"{fat}");
    File.WriteAllText("/Users/lukakocegov/RiderProjects/calorie_calculator/data/carbohydrate.txt", $"{carbohydrate}");
    File.WriteAllText("/Users/lukakocegov/RiderProjects/calorie_calculator/data/calorie.txt", $"{calorie}");
}

var a = Console.ReadLine();
if (a == "+")
{
    float massa =
        Convert.ToSingle(File.ReadAllText("/Users/lukakocegov/RiderProjects/calorie_calculator/data/massa.txt"));
    float protein =
        Convert.ToSingle(File.ReadAllText("/Users/lukakocegov/RiderProjects/calorie_calculator/data/protein.txt"));
    float fat = Convert.ToSingle(File.ReadAllText("/Users/lukakocegov/RiderProjects/calorie_calculator/data/fat.txt"));
    float carbohydrate =
        Convert.ToSingle(File.ReadAllText("/Users/lukakocegov/RiderProjects/calorie_calculator/data/carbohydrate.txt"));
    float calorie =
        Convert.ToSingle(File.ReadAllText("/Users/lukakocegov/RiderProjects/calorie_calculator/data/calorie.txt"));

    Calculator(massa, protein, fat, carbohydrate, calorie);
}
else
{
    File.WriteAllText("/Users/lukakocegov/RiderProjects/calorie_calculator/report.txt",
        "Пора совершить ультробелковый прием пищи");

    File.WriteAllText("/Users/lukakocegov/RiderProjects/calorie_calculator/data/massa.txt", "0");
    File.WriteAllText("/Users/lukakocegov/RiderProjects/calorie_calculator/data/protein.txt", "0");
    File.WriteAllText("/Users/lukakocegov/RiderProjects/calorie_calculator/data/fat.txt", "0");
    File.WriteAllText("/Users/lukakocegov/RiderProjects/calorie_calculator/data/carbohydrate.txt", "0");
    File.WriteAllText("/Users/lukakocegov/RiderProjects/calorie_calculator/data/calorie.txt", "0");
}