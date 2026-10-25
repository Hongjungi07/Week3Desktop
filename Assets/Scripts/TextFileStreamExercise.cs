using UnityEngine;
using System.IO;

public class TextFileStreamExercise : MonoBehaviour
{
    private void Awake()
    {
        Stream writeStream = new FileStream("TextFileStream", FileMode.Create);
        
        StreamWriter streamWriter = new StreamWriter(writeStream);

        streamWriter.Write(35);
        streamWriter.Write(12.34f);
        streamWriter.Write("여러분 안녕하세요, 고박사입니다.");

        streamWriter.Close();

        Stream readStream = new FileStream("TextFileStream", FileMode.Open);

        StreamReader streamReader = new StreamReader(readStream);


        while (streamReader.EndOfStream == false)
        {
            Debug.Log(streamReader.ReadLine());
        }


        streamReader.Close();
    }
}
