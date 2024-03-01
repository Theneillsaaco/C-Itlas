namespace t2;

public class t2
{
    public static void Main(string[] args)
    {
        #region "Datos"
        var animals = new Animal?[]
        {
            new Cat { Name = "Karen", Born = new(year: 2022, month: 8,
            day: 23), Legs = 4, IsDomestic = true, vaccinated = true },
            null,
            new Cat { Name = "Mufasa", Born = new(year: 1994, month: 6,
            day: 12) },
            new Spider { Name = "Sid Vicious", Born = DateTime.Today,
            IsPoisonous = true},
            new Spider { Name = "Captain Furry", Born = DateTime.Today },
        };
        #endregion 
        #region "Verificacion"
        foreach (Animal? animal in animals)
        {
            string message;
            switch (animal)
            {
                case Cat fourLeggedCat when fourLeggedCat.Legs == 4:
                    message = $"The cat named {fourLeggedCat.Name} has four legs.";
                    Console.WriteLine(message);
                    break;
                case Cat wildCat when wildCat.IsDomestic == false:
                    message = $"The non-domestic cat is named {wildCat.Name}.";
                    Console.WriteLine(message);
                    break;
                case Cat cat:
                    message = $"The cat is named {cat.Name}.";
                    Console.WriteLine(message);
                    break;
                default: // default is always evaluated last.
                    message = $"{animal.Name} is a {animal.GetType().Name}.";
                    Console.WriteLine(message);
                    break;
                case Spider spider when spider.IsPoisonous:
                    message = $"The {spider.Name} spider is poisonous. Run!";
                    Console.WriteLine(message);
                    break;
                case null:
                    message = "The animal is null.";
                    Console.WriteLine(message);
                    break;
            }
        }
        #endregion
    }
}