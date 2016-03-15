using UnityEngine;
using System.Collections;

public class Picking : MonoBehaviour {

    public Camera pickingCamera;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetMouseButtonDown(0) == true)
        {
            //creates a ray thats cast from the mouse position nto the world
            Vector3 mousePosition = Input.mousePosition;
            Ray pickingRay = pickingCamera.ScreenPointToRay(mousePosition);
            //use the ray to see if any object collides with it
            RaycastHit hit;
            bool success = Physics.Raycast(pickingRay, out hit);
            if (success)
            {
                if(hit.collider.gameObject.tag == "Tooth")
                {
                    hit.collider.gameObject.SetActive(false);
                }
                Debug.Log("The name of the picked object is: " + hit.collider.gameObject);
            }
        }
	}
}
