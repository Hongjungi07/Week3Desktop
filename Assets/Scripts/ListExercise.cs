using System.Collections.Generic;
using UnityEngine;

public class ListExercise : MonoBehaviour
{
    private void Awake()
    {
        List<int> list = new List<int>();
        
        for (int i = 0; i < 5; i++)
        {
            list.Add(i);
        }

        PrintList<int>(list);

        list.Insert(0, 10000);

        PrintList(list);

        list.RemoveAt(1);

        PrintList(list);

        Debug.Log($"List Count : {list.Count}");

        list.Clear();

        Debug.Log($"List Count : {list.Count}");
    }

    public void PrintList<T>(List<T> list)
    {
        Debug.Log("================================");

        for (int i = 0; i < list.Count; i++)
        {
            Debug.Log($"list[{i}] = {list[i]}");
        }
    }
}
