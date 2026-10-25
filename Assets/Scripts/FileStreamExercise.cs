using UnityEngine;
using System.IO;
using System;

public class FileStreamExercise : MonoBehaviour
{
    private void Awake()
    {
        int writeData = 35;
        
        Stream writeStream = new FileStream("Filestream.dat", FileMode.Create);
        
        byte[] writeBytes = BitConverter.GetBytes(writeData);

        writeStream.Write(writeBytes, 0, writeBytes.Length);

        writeStream.Close();


        byte[] readBytes = new Byte[8];

        Stream readStream = new FileStream("Filestream.dat", FileMode.Open);

        readStream.Read(readBytes, 0, readBytes.Length);

        int readData = BitConverter.ToInt32(readBytes, 0);

        readStream.Close();


        Debug.Log($"파일에 저장되어 있던 데이터 : {readData}");
    }
}
