using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakfast : MonoBehaviour
{
    public void OnTriggerStay(Collider other)
    {
        _GameManager.instance.gameText.text = "Press E to Make Breakfast";
        if (Input.GetKeyDown(KeyCode.E))
        {
            _GameManager.instance.gameText.text = " ";

        }
    }

}
