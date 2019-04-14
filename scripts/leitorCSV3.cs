using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.IO;
using System.Collections.Generic;

public class leitorCSV3 : MonoBehaviour
{

    public GameObject cubeTest;
    public TextAsset csvFile;
    private LineRenderer desenho;

    // Start is called before the first frame update
    void Start()
    {
        var desenho = GetComponent<LineRenderer>();



    }


    void Update()
    {




        string[] records = csvFile.text.Split('\n');
        List<Vector3> points = new List<Vector3>();
        for (int i = 1; i < records.Length; i++)
        {
            string[] fields = records[i].Split(',');



            float x = float.TryParse(fields[1], out x) ? x : 0;
            float y = float.TryParse(fields[2], out y) ? y : 0;
            float z = float.TryParse(fields[3], out z) ? z : 0;

             points.Add(new Vector3(x, y, z));


           cubeTest.transform.Translate(new Vector3(x, y, z));
        }



    }
}
