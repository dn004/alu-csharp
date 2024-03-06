using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text.Json;

public class JSONStorage
{
    Dictionary<string, object> objects = new Dictionary<string, object>();
    readonly string filename = "inventory_manager.json";
    string? path;

    string? baseDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
    string newDirectoryName = "storage";

    string? Data = string.Empty;

    public Dictionary<string, object> All()
    {
        return objects;
    }

    public void New(object value)
    {
        BaseClass? classObject = value as BaseClass;
        string obj_id = $"{value.GetType().Name}.{classObject?.Id}";

        objects.Add(obj_id, value);
    }

    public void Save()
    {
        string newDirectoryFullPath = Path.Combine(baseDirectory, newDirectoryName);

        if (!Directory.Exists(newDirectoryFullPath))
        {
            Directory.CreateDirectory(newDirectoryFullPath);
        }

        path = Path.Combine(newDirectoryFullPath, filename);

        foreach (object obj in objects.Values)
        {
            Data = JsonSerializer.Serialize(obj);
            Console.WriteLine(Data);

            if (!File.Exists(path))
            {
                // Handle case where file doesn't exist yet
            }
            else
            {
                // Handle case where file already exists
            }

            File.WriteAllText(path, Data);
        }
    }
}
