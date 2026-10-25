using UnityEngine;
using System.IO;
using System;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
public class Player
{
    public string name; 
    public int age;

    [NonSerialized]
    public string address;

    public Player(string name, int age, string address)
    {
        this.name = name;
        this.age = age;
        this.address = address;
    }

    public void PrintData()
    {
        Debug.Log($"{name} : 나이({age}), 주소({address})");
    }
}

public class BinaryFormatterExercise : MonoBehaviour
{
    private void Awake()
    {
        Stream writeStream = new FileStream("BinaryFormatter", FileMode.Create);

        BinaryFormatter binaryFormatter = new BinaryFormatter();

        Player writePlayer = new Player("고박사", 35, "고박사의 유니티 노트");

        binaryFormatter.Serialize(writeStream, writePlayer);

        writeStream.Close();

        
        Stream readStream = new FileStream("BinaryFormatter", FileMode.Open);

        Player readPlayer = binaryFormatter.Deserialize(readStream) as Player;

        readStream.Close();

        readPlayer.PrintData();
    }
}
