using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Washingup : MonoBehaviour
{
    private bool hasTeleported;

    public Transform TeleportTo;
    private void OnTriggerStay(Collider other)
    {
        if(!hasTeleported)
        {
            _GameManager.instance.gameText.text = "Press E to Wash the dishes";
            if (Input.GetKeyDown(KeyCode.E))
            {
                _GameManager.instance.Player.transform.position = TeleportTo.position;
                _GameManager.instance.Teleported = true;
                _GameManager.instance.checkpoint5 = true;
                _GameManager.instance.Player.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().rotateView = false;
                _GameManager.instance.Player.transform.rotation = TeleportTo.rotation;
                StartCoroutine(ResetRotation());
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        _GameManager.instance.gameText.text = "  ";
    }
    
    IEnumerator ResetRotation ()
    {
        yield return new WaitForSeconds(1.5f);
        _GameManager.instance.Player.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().rotateView = true;
        hasTeleported = true;
    }

}
