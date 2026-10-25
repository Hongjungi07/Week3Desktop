using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackExercise : MonoBehaviour
{
    private void Awake()
    {
        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < 5; i++)
        {
            stack.Push(i);
        }

        Debug.Log($"Stack Count : {stack.Count}");

        while (stack.Count > 0)
        {
            Debug.Log($"Stack Data : {stack.Pop()}");
        }
        
        Debug.Log($"Stack Count : {stack.Count}");
    }

    //private void Awake()
    //{
    //    Stack stack = new Stack();

    //    for (int i = 0; i < 5; i++)
    //    {
    //        stack.Push(i);
    //    }

    //    Debug.Log($"Stack Count = {stack.Count}");

    //    Debug.Log($"가장 마지막에 추가된 요소 = {stack.Peek()}");

    //    Debug.Log($"Stack Count = {stack.Count}");

    //    object data = stack.Pop();
    //    Debug.Log($"스택에서 빠져나온 요소 = {data}");

    //    Debug.Log($"Stack Count = {stack.Count}");

    //    stack.Clear();

    //    Debug.Log($"Stack Count = {stack.Count}");
    //}
}
