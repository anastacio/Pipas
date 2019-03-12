using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuScene : MonoBehaviour
{

	private CanvasGroup fadeGroup;
	private float fadeInSpeed = 0.33f;

 
    private void Start()
    {
        //grab the only CanvasGroup in the sccene
        fadeGroup = FindObjectOfType<CanvasGroup>();

        // Start with a white screen
        fadeGroup.alpha = 1;
        
    }

    // Update is called once per frame
    private void Update()
    {
    	// fade-in
    	fadeGroup.alpha = 1 - Time.timeSinceLevelLoad * fadeInSpeed;
    	
        
    }
}
