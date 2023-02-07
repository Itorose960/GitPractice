using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ClickDragScript : MonoBehaviour
{
    private GameObject heldObject;
    List<Color> colours;

    private void Start()
    {
        colours = new List<Color>();
        colours.Add(Color.red);
        colours.Add(Color.green);
        colours.Add(Color.gray);
        colours.Add(Color.white);
        colours.Add(Color.cyan);
        colours.Add(Color.magenta);
        colours.Add(Color.yellow);
    }

    private void FixedUpdate()
    {
        if(heldObject != null)
        {
            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            pos.z = heldObject.transform.position.z;
            heldObject.transform.position = pos;
        }
    }
    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GrabItem();
        }
        if(Input.GetMouseButtonUp(0) && heldObject != null)
        {
            heldObject.GetComponent<SpriteRenderer>().color = Color.white;
            heldObject = null;
        }
    }

    private void GrabItem()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        if(Physics.Raycast(ray, out hit)) { 
            if(hit.collider.CompareTag("Draggable"))
            {
                heldObject = hit.collider.gameObject;
                //heldObject.GetComponent<SpriteRenderer>().color = Color.blue;
                heldObject.GetComponent<SpriteRenderer>().color = colours[UnityEngine.Random.Range(0, colours.Count)];
            }
        }
        
    }
}
