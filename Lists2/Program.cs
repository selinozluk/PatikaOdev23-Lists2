// Kahve isimlerini tutmak için boş liste
List<string> coffeeList = new List<string>();

// Kullanıcıdan 5 kahve ismi alır
for (int i = 0; i < 5; i++)
{
    Console.Write($"Kahve {i + 1}: ");
    string coffeeName = Console.ReadLine();
    coffeeList.Add(coffeeName);
}

// Yazdırılacak olan kahve isimlerinin başlığı
Console.WriteLine("\nGirilen Kahve İsimleri:");

// Kahve isimlerini ekrana yazdırır
foreach (var coffee in coffeeList)
{
    Console.WriteLine(coffee);
}