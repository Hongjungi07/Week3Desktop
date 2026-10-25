using UnityEngine;
using System.IO;

public class DirectoryInfoExercise : MonoBehaviour
{
    private void Awake()
    {
        DirectoryInfo currentDirectory;

        string path = Application.dataPath;

        currentDirectory = new DirectoryInfo(path);

        currentDirectory.CreateSubdirectory("TestA");

        Debug.Log($"전체경로 + 폴더이름 : {currentDirectory.FullName}");
        Debug.Log($"폴더이름 : {currentDirectory.Name}");

        bool isExist = currentDirectory.Exists;
        Debug.Log($"{currentDirectory.Name} 폴더 존재 여부 : {isExist}");

        FileAttributes attr = currentDirectory.Attributes;
        Debug.Log($"{currentDirectory.Name} 폴더 속성 : {attr}");

        Debug.Log("== 현재 폴더에 존재하는 모든 폴더 ==");
        foreach (DirectoryInfo directory in currentDirectory.GetDirectories())
        {
            Debug.Log(directory.Name);
        }

        Debug.Log("== 현재 폴더에 존재하는 모든 파일 ==");
        foreach (FileInfo file in currentDirectory.GetFiles())
        {
            Debug.Log(file.Name);
        }
    }
}
