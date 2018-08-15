using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakfast : MonoBehaviour
{
    public void OnTriggerStay(Collider other)
    {
        _GameManager.instance.Gametext.text = "Press E to Make Breakfast";
        if (Input.GetKeyDown(KeyCode.E))
        {
            _GameManager.instance.Gametext.text = " ";

        }
    }

}
