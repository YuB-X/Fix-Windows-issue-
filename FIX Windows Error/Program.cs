using Microsoft.Win32;

// Specify the registry key path
const string registryKeyPath = @"HKEY_CLASSES_ROOT\exefile\shell\open\command";

// Specify the new value to set
const string newValue = "\"%1\" %*";

// Open the registry key for writing
Registry.SetValue(registryKeyPath, "", newValue);

Console.WriteLine("FIXED");

while (true)
{
    Console.ReadLine();
}