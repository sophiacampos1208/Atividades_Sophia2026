//Autoriza o uso de emoji e caracteres especiais
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Digite a Temperartura em C°🌡️:");
float.TryParse(Console.ReadLine(), out float celsius);
float resultado = (celsius * 9 / 5) + 32;
Console.WriteLine($"A temperatura é C°: {celsius}\nA conversão em F°: {resultado}");

Console.WriteLine("Digite a Temperartura em F°🥵:");
float.TryParse(Console.ReadLine(), out float Fahrenheit);
float resposta = (Fahrenheit - 32 ) * 5/9;
Console.WriteLine($"A temperatura é F°: {Fahrenheit}\nA conversão em C°: {resposta}");

Console.WriteLine("Digite a Temperartura em K°😰:");
float.TryParse(Console.ReadLine(), out float Kelvin);
float resto = (Kelvin - 273.15F); 
Console.WriteLine($"A temperatura é K°: {Kelvin}\nA conversão em C°: {resposta}");

Console.WriteLine("Digite a Temperartura em K°:");
float.TryParse(Console.ReadLine(), out Kelvin);
float F = (Kelvin - 273.15f)*9/5+32;
Console.WriteLine($"A temperatura é K°: {Kelvin}\nA conversão em F°: {resposta}");




