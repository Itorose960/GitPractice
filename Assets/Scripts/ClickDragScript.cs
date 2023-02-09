using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ClickDragScript : MonoBehaviour
{
<<<<<<< HEAD
    private GameObject object1;
=======
    public Sprite shrek;
    private GameObject heldObject;
<<<<<<< HEAD
    List<Color> colouris;

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
=======
>>>>>>> 340975cc4faa8e26f30ca71243afe07f5bed6108
>>>>>>> bde1b64cfa2f4e7271bc461afd12680b56f88351

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
<<<<<<< HEAD
            object1.GetComponent<SpriteRenderer>().color = Color.white;
            object1 = null;
=======
            heldObject.GetComponent<SpriteRenderer>().sprite = shrek;
            heldObject = null;
>>>>>>> 340975cc4faa8e26f30ca71243afe07f5bed6108
        }
    }

    private void GrabItem()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        if(Physics.Raycast(ray, out hit)) { 
            if(hit.collider.CompareTag("Drug"))
            {
<<<<<<< HEAD
                heldObject = hit.collider.gameObject;
                //heldObject.GetComponent<SpriteRenderer>().color = Color.blue;
                heldObject.GetComponent<SpriteRenderer>().color = colours[UnityEngine.Random.Range(0, colours.Count)];
=======
                object1 = hit.collider.gameObject;
                object1.GetComponent<SpriteRenderer>().color = Color.blue;
>>>>>>> bde1b64cfa2f4e7271bc461afd12680b56f88351
            }
        }
        
    }
}
