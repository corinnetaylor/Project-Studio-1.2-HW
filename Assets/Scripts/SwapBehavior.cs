using UnityEngine;
using System.Collections;

public class SwapBehavior : MonoBehaviour {
	
	
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space) == true){
			
			if (Application.loadedLevelName == "Terrain"){
				Application.LoadLevel ("Chair");
			} else {
				Application.LoadLevel ("Terrain");
			}
			
			
		}
	}
	
	
}
