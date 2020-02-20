using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadOnClick : MonoBehaviour 
{
	public GameObject LoadingImage;
   public void LoadScene(int scene)
   {
   	LoadingImage.SetActive(true);
   	SceneManager.LoadScene(scene);
   }
}
