using System.Collections.Generic;

namespace 
public static class GenericTextFileProccessor
{
    public static List<T> LoadFromTextFile<T>(string filePath) where T:class,new()
    {
        var lines = System.IO.File.ReadAllLines(filePath).to;
        T entry = new T();

    }
}