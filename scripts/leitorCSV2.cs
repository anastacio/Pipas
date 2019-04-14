using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.IO;
using System.Collections.Generic;

public class leitorCSV2 : MonoBehaviour
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

            float x = float.Parse(fields[1]);
            float y = float.Parse(fields[2]);
            float z = float.Parse(fields[3]);



            cubeTest.transform.Translate(new Vector3(x, y, z) * Time.deltaTime);
        }
    }
}