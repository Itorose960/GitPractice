using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCube : MonoBehaviour
{
    [SerializeField] private GameObject thing;
    //[SerializeField] private GameObject thing2;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) //M: changes the key to Space
        {
            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            pos.z = 0;
            Instantiate(thing, pos, Quaternion.identity);

            Debug.Log("Marga was here."); //M: a Debug Log appears when E is pressed
        }
    }
}
