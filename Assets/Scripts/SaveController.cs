using System;
using System.IO;
using System.Linq;
using System.Text;
using UnityEngine;

public class SaveController
{
    const string nameFileSave = "/data.sav";

    public static void Save<T>(T _data)
    {
        Debug.Log(Application.persistentDataPath + nameFileSave);
        var hex = DataToString(_data);
        File.WriteAllText(Application.persistentDataPath + nameFileSave, hex.Replace("-", ""));
    }

    public static T Load<T>()
    {
        if (File.Exists(Application.persistentDataPath + nameFileSave))
        {
            var filer = File.ReadAllText(Application.persistentDataPath + nameFileSave);
            int charsCount = filer.Length;
            byte[] bytes = new byte[charsCount / 2];
            // UnCrypt
            for (int i = 0; i < charsCount; i += 2)
            {
                bytes[i / 2] =
                (byte)(byte.MaxValue - Convert.ToByte(filer.Substring(i, 2), 16));
            }
            var result = Encoding.UTF8.GetString(bytes, 0, bytes.Length);
            return JsonUtility.FromJson<T>(result);
        }
        else
        {
            return default(T);
        }
    }

    private static string DataToString<T>(T _data)
    {
        byte[] byteData = DataToBytes(_data);
        return BitConverter.ToString(byteData);
    }

    private static byte[] DataToBytes<T>(T _data)
    {
        string jsonSave = JsonUtility.ToJson(_data);
        byte[] byteData = Encoding.UTF8.GetBytes(jsonSave);
        // Crypt
        for (int i = 0; i < byteData.Count(); i++)
        {
            byteData[i] = (byte)(byte.MaxValue - byteData[i]);
        }

        return byteData;
    }
}
