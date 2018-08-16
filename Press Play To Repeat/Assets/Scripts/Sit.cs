using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sit : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        _GameManager.instance.gameText.text = "Press E to eat";
        if (Input.GetKeyDown(KeyCode.E) && _GameManager.instance.isSiting == false)
        {
            //starting the sitting animation.
            _GameManager.instance.Player.SetActive(false);
            _GameManager.instance.sitcam.SetActive(true);
            _GameManager.instance.Plate.SetActive(false);
            _GameManager.instance.Plate2.SetActive(true);
        }
    }

}
