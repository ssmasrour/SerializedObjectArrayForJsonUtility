using UnityEngine;

public static class JsonHelper
{
    public static T[] FromJson<T>(string json)
    {
        Container<T> container = JsonUtility.FromJson<Container<T>>(json);
        return container.Items;
    }

    public static string ToJson<T>(T[] array)
    {
        Container<T> container = new Container<T>();
        container.Items = array;
        return JsonUtility.ToJson(container);
    }

    public static string ToJson<T>(T[] array, bool prettyPrint = false)
    {
        Container<T> container = new Container<T>();
        container.Items = array;
        return JsonUtility.ToJson(container, prettyPrint);
    }

    [System.Serializable]
    private class Container<T>
    {
        public T[] Items;
    }
}
