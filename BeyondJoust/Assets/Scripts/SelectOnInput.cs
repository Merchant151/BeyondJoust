using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class SelectOnInput : MonoBehaviour
{
	public EventSystem eventSystem;
	public GameObject selectedObject;
	private bool buttonSelected = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	Debug.Log(buttonSelected);
    	// if()
        if(Input.GetAxisRaw("Vertical") != 0 && buttonSelected == false){
        	Debug.Log("Reached vertical change");
        	eventSystem.SetSelectedGameObject(selectedObject);
        	buttonSelected = true;
        }

    }
    private void onDisable(){
    	buttonSelected = false;
    }
}
