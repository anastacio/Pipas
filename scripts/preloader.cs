using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class preloader : MonoBehaviour
{
	private CanvasGroup fadeGroup;
	private float loadTime;
	private float minimumLogoTime = 3.0f; // tempo minimo da cena

    private void Start()
    {
    	// grab only CanvasGroup in the scene
    	fadeGroup = FindObjectOfType<CanvasGroup>();

    	// começa com a tela branca
    	fadeGroup.alpha = 1;

    	// pre load do app

    	//$$

    	//marcação do time da cena


    	// adequa o tempo de aparição do logo com o carregamento do app
if(Time.time < minimumLogoTime)
loadTime = minimumLogoTime;
else
loadTime = Time.time;
        
    }

    private void Update()
    {
    	//fade - in
if(Time.time < minimumLogoTime)
{
	fadeGroup.alpha = 1 - Time.time; 
}

    	//fade-out 

if(Time.time > minimumLogoTime && loadTime != 0)
{
	fadeGroup.alpha = Time.time - minimumLogoTime;
	if(fadeGroup.alpha >= 1)
	{
		//Debug.Log("muda a cena");
        SceneManager.LoadScene("Tela_registro");
	}
    }
}
}
