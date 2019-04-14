using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.IO;

public class LeitorCSV : MonoBehaviour
{
    public GameObject cubeTest;
    public TextAsset csvFile;

    // Update is called once per frame
    void Update()
    {
        readCSV();
    }

    void readCSV()
    {
        string[] records = csvFile.text.Split('\n');
        for (int i = 1; i < records.Length; i++)
        {
            string[] fields = records[i].Split(',');
            cubeTest.transform.Translate(float.Parse(fields[1]), float.Parse(fields[2]), float.Parse(fields[3]));

        }
    }
}



