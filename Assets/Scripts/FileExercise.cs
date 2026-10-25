using UnityEngine;
using System.IO;

public class FileExercise : MonoBehaviour
{
    private void Awake()
    {
        FileStream file = File.Create("a.dat");

        file.Close();

        File.Copy("a.dat", "b.dat");

        File.Move("a.dat", "c.dat");

        bool isExist = File.Exists("c.dat");
        Debug.Log($"c.dat 파일 존재 여부 : {isExist}");

        FileAttributes attr = File.GetAttributes("c.dat");
        Debug.Log($"c.dat 파일 속성 : {attr}");

        File.Delete("c.dat");
        File.Delete("b.dat");

    }
}
