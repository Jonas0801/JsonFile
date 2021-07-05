# JsonFile
Save and load json file
<br>Generic json function</br>
Example
```C#
[System.Serializable]
public class Data
{
    public string name;
}
```

```C#
public class A 
{
    private Data myData = new Data() { name = "Hello world!" };
    private const string FILE_NAME = "MyData.json"; 

    private void Start()
    {
        Json.SaveJsonFile(myData, FILE_NAME);
        bool isLoadData = Json.LoadJsonFile(ref myData, FILE_NAME);
    }
}
```
