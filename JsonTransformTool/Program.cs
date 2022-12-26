using JsonTransform;

if (args.Length != 1)
{
    Console.WriteLine("Usage: PrepareUndefinedTargets.exe <file>");
    return;
}

var filePath = args[0];
if (!File.Exists(filePath))
{
    Console.WriteLine($"Файл {filePath} не существует!");
    return;
}

string content = File.ReadAllText(filePath);

var targetProcessor = new TargetProcessor(content);

try
{
    targetProcessor.ProcessUndefined();    
}
catch(ArgumentException ex)
{
    Console.WriteLine($"Некорректный JSON: {ex.Message}");
    return;
}

targetProcessor.Export();

File.WriteAllText(".\\result.json", targetProcessor.Export());

Console.WriteLine("Обработка завершена");
Console.ReadLine();

return;