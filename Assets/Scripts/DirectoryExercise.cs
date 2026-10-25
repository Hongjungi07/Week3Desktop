using UnityEngine;
using System.IO;

public class DirectoryExercise : MonoBehaviour
{
    private void Awake()
    {
        Directory.CreateDirectory("Exercise");

        Directory.Move("Exercise", "Exercise2");

        bool isExist = Directory.Exists("Exercise2");
        Debug.Log($"Exercise2 폴더 존재 여부 : {isExist}");

        string[] directorys = Directory.GetDirectories("Exercise2");
        Debug.Log($"하위 폴더 개수 : {directorys.Length}");

        string[] files = Directory.GetFiles("Exercise2");
        Debug.Log($"하위 파일 개수 : {files.Length}");

        Directory.Delete("Exercise2");
    }
}
