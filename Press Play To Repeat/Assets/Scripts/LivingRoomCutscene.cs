using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivingRoomCutscene : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        _GameManager.instance.gameText.text = "Press E to Look at picture";

        if (Input.GetKeyDown(KeyCode.E))
        {
            _GameManager.instance.Player.SetActive(false);
            _GameManager.instance.cutsceneCam.SetActive(true);
            _GameManager.instance.Dice.SetActive(true);
            _GameManager.instance.gameText.text = " ";
            _GameManager.instance.Picture.SetBool("End", true);
            _GameManager.instance.Grandson.SetActive(true);
            StartCoroutine(EndAnim());
        }
    }
    private void OnTriggerExit(Collider other)
    {
        _GameManager.instance.gameText.text = " ";
    }

    IEnumerator EndAnim()
    {
        yield return new WaitForSeconds(13.5f);
        _GameManager.instance.Player.SetActive(true);
        _GameManager.instance.cutsceneCam.SetActive(false);
        _GameManager.instance.Dice.SetActive(false);
        _GameManager.instance.Trigger.SetActive(false);
        _GameManager.instance.Grandson.SetActive(false);
    }
}
