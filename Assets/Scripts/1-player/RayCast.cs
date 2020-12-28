using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{
	private GameObject moveObject = null;
	bool isRay = false;
	int seconds = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
	     if(Input.GetKeyDown(KeyCode.E)) {
			 Ray rayOrigin = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
			 RaycastHit hitInfo;
			 int layer_mask = LayerMask.GetMask("cubes");
			 if (Physics.Raycast(rayOrigin, out hitInfo,Mathf.Infinity, layer_mask)) {
			 	Debug.Log("ray hits: "+hitInfo.collider.gameObject.name);
			 	moveObject = hitInfo.collider.gameObject;
			 	isRay = true;
			 	seconds = 0;
		 	 }
	 	 }
	 	 if (isRay){
		 	 if(Input.GetKeyDown(KeyCode.G)) {
		 	 	moveObject.transform.position += new Vector3(-1f,0f,0f);
		 	 }
		 	  if(Input.GetKeyDown(KeyCode.J)) {
		 	 	moveObject.transform.position += new Vector3(1f,0f,0f);
		 	 }
		 	  if(Input.GetKeyDown(KeyCode.Y)) {
		 	 	moveObject.transform.position += new Vector3(0f,0f,1f);
		 	 }
		 	  if(Input.GetKeyDown(KeyCode.H)) {
		 	 	moveObject.transform.position += new Vector3(0f,0f,-1f);
		 	 }
		 	 seconds++;
	 	 }
	 	 if(seconds >= 100) {
	 	 	seconds = 0;
	 	 	isRay = false; 
	 	 	moveObject = null;
	 	 }

    }
}
