using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lineCSV : MonoBehaviour
{


    // Creates a line renderer that follows a Sin() function
    // and animates it.

    Color c1 = Color.yellow;
    Color c2 = Color.red;
    int lengthOfLineRenderer = 10000;
   
    public TextAsset csvFile;

    void Start()
    {
        LineRenderer lineRenderer = gameObject.AddComponent<LineRenderer>();
        lineRenderer.material = new Material(Shader.Find("Sprites/Default"));
        lineRenderer.SetColors(c1, c1);
        lineRenderer.SetWidth(0.5f, 0);
        lineRenderer.SetVertexCount(lengthOfLineRenderer);

        float alpha = 1.0f;
        Gradient gradient = new Gradient();
        gradient.SetKeys(
            new GradientColorKey[] { new GradientColorKey(c1, 0.0f), new GradientColorKey(c2, 1.0f) },
            new GradientAlphaKey[] { new GradientAlphaKey(alpha, 0.0f), new GradientAlphaKey(alpha, 1.0f) }
        );
        lineRenderer.colorGradient = gradient;
    }

    void Update()
    {
        LineRenderer lineRenderer = GetComponent<LineRenderer>();
        var points = new Vector3[lengthOfLineRenderer];
        var t = Time.time;



        string[] records = csvFile.text.Split('\n');

        for (int i = 1; i < records.Length || i < lengthOfLineRenderer; i++)
        {
            string[] fields = records[i].Split(',');

            float x = float.Parse(fields[1]);
            float y = float.Parse(fields[2]);
            float z = float.Parse(fields[3]);


            {
                points[i] = new Vector3(x, y, z);

            }
            lineRenderer.SetPositions(points);
        }
    }
}