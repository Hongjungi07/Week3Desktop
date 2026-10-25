using UnityEngine;
using System.IO;

public class BinaryFileStreamExercise : MonoBehaviour
{
    private void Awake()
    {
        Stream writeStream = new FileStream("BinaryFileStream.dat", FileMode.Create);
        
        BinaryWriter binaryWriter = new BinaryWriter(writeStream);

        binaryWriter.Write(35);
        
        binaryWriter.Write(12.34f);
        
        binaryWriter.Write("여러분 안녕하세요, 고박사입니다.");

        
        binaryWriter.Close();

        
        Stream readStream = new FileStream("BinaryFileStream.dat", FileMode.Open);

        BinaryReader binaryReader = new BinaryReader(readStream);

        Debug.Log($"File Size : {readStream.Length} Bytes");

        Debug.Log(binaryReader.ReadInt32());
        Debug.Log(binaryReader.ReadSingle());
        Debug.Log(binaryReader.ReadString());

        binaryReader.Close();
    }
}
