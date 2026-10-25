using UnityEngine;
using System.IO;

public class FileInfoExercise : MonoBehaviour
{
    private void Awake()
    {
        FileInfo fileInfo = new FileInfo("d.dat");

        FileStream file = fileInfo.Create();

        file.Close();

        fileInfo.CopyTo("e.dat");

        fileInfo.MoveTo("f.dat");

        bool isExist = fileInfo.Exists;
        Debug.Log($"{fileInfo.Name} 존재 여부 : {isExist}");

        FileAttributes attr = fileInfo.Attributes;
        Debug.Log($"{fileInfo.Name} 파일 속성 : {attr}");

        fileInfo.Delete();
    }
}

