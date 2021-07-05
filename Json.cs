using System.IO;
using UnityEngine;

public class Json : MonoBehaviour
{
    public void SaveJsonFile<T>(T data, string fileName) where T : class
    {
        //save json file
        string json = JsonUtility.ToJson(data, true);
        StreamWriter saveFile = new StreamWriter(Path.Combine(Application.persistentDataPath, fileName));
        saveFile.Write(json);
        saveFile.Close();
        Debug.Log(json);
        Debug.Log(Path.Combine(Application.persistentDataPath, fileName));
        Debug.Log($"{fileName}儲存資料成功");
    }

    public bool LoadJsonFile<T>(ref T data, string fileName) where T : class
    {
        //load json file
        if (!File.Exists(Path.Combine(Application.persistentDataPath, fileName)))
        {
            Debug.Log($"無{fileName} Json資料");
            return false;
        }
        StreamReader loadFile = new StreamReader(Path.Combine(Application.persistentDataPath, fileName));
        string loadJson = loadFile.ReadToEnd();
        loadFile.Close();
        data = JsonUtility.FromJson<T>(loadJson);
        Debug.Log(loadJson);
        Debug.Log(Path.Combine(Application.persistentDataPath, fileName));
        Debug.Log($"{fileName}資料讀取成功");
        return true;
    }
}
