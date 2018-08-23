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
            // starting the animation by pressing E.
            Debug.Log("Starting Animation");
            _GameManager.instance.Player.SetActive(false);
            _GameManager.instance.cutsceneCam.SetActive(true);
            _GameManager.instance.Dice.SetActive(true);
            _GameManager.instance.gameText.text = " ";
            _GameManager.instance.Picture.SetBool("End", true);
            _GameManager.instance.Grandson.SetActive(true);
            _GameManager.instance.heyTom.PlayDelayed(3);
            StartCoroutine(EndAnim());
        }
    }
    private void OnTriggerExit(Collider other)
    {
        //changing the game text to be blank.
        _GameManager.instance.gameText.text = " ";
    }

    IEnumerator EndAnim()
    {
        //sets up the animation and waits fort it to finish.
        Debug.Log("Ending Animation");
        yield return new WaitForSeconds(17f);
        _GameManager.instance.Player.SetActive(true);
        _GameManager.instance.cutsceneCam.SetActive(false);
        _GameManager.instance.Dice.SetActive(false);
        _GameManager.instance.Trigger.SetActive(false);
        _GameManager.instance.Grandson.SetActive(false);
        _GameManager.instance.checkpoint1 = true;
    }
}
