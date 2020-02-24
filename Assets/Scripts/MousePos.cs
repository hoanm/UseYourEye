using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePos : MonoBehaviour
{
    public GameObject particle;
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
			Debug.Log ("Jumpppp! X = " + Input.mousePosition.x);
			Debug.Log ("Jumpppp! Y = " + Input.mousePosition.y);
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray))
			{
                Instantiate(particle, transform.position, transform.rotation);
				Debug.Log (" You have clicked the button!" + transform.position);
			}
        }
    }
}
