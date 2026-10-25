using System.Collections.Generic;
using UnityEngine;

public class DictionaryExercise : MonoBehaviour
{
    private void Awake()
    {
        Dictionary<string, string> dictionary = new Dictionary<string, string>();

        dictionary["1"] = "First";
        dictionary["2"] = "Second";
        dictionary["3"] = "Third";

        PrintDictionary(dictionary);

        dictionary.Add("사과", "Apple");

        PrintDictionary(dictionary);

        dictionary.Remove("1");

        PrintDictionary(dictionary);
    }

    public void PrintDictionary<TKey, TValue>(Dictionary<TKey, TValue> dic)
    {
        Debug.Log("========================");

        Debug.Log($"Dictionary Count : {dic.Count}");

        foreach (var d in dic.Keys)
        {
            Debug.Log($"dictionary[{d}] = {dic[d]}");
        }
    }
}
