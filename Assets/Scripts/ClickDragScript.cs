using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickDragScript : MonoBehaviour
{
    private GameObject object1;

    private void FixedUpdate()
    {
        if(object1 != null)
        {
            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            pos.z = object1.transform.position.z;
            object1.transform.position = pos;
        }
    }
    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GrabItem();
        }
        if(Input.GetMouseButtonUp(0) && object1 != null)
        {
            object1.GetComponent<SpriteRenderer>().color = Color.white;
            object1 = null;
        }
    }

    private void GrabItem()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        if(Physics.Raycast(ray, out hit)) { 
            if(hit.collider.CompareTag("Drug"))
            {
                object1 = hit.collider.gameObject;
                object1.GetComponent<SpriteRenderer>().color = Color.blue;
            }
        }
        
    }
}
