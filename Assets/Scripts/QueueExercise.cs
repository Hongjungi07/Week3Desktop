using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueueExercise : MonoBehaviour
{
    private void Awake()
    {
        Queue<int> queue = new Queue<int>();

        for (int i = 0; i < 5; i++)
        {
            queue.Enqueue(i);
        }

        Debug.Log($"Queue Count : {queue.Count}");

        while (queue.Count > 0)
        {
            Debug.Log($"Queue Data : {queue.Dequeue()}");
        }

        Debug.Log($"Queue Count : {queue.Count}");
    }

    //private void Awake()
    //{
    //    Queue queue = new Queue();

    //    for (int i = 0; i < 5; i++)
    //    {
    //        queue.Enqueue(i);
    //    }

    //    Debug.Log($"Queue Count = {queue.Count}");

    //    Debug.Log($"현재 0번 요소 = {queue.Peek()}");

    //    Debug.Log($"Queue Count = {queue.Count}");

    //    object data = queue.Dequeue();
    //    Debug.Log($"큐에서 빠져나온 요소 = {data}");

    //    Debug.Log($"Queue Count = {queue.Count}");

    //    queue.Clear();

    //    Debug.Log($"Queue Count = {queue.Count}");
    //}
}
