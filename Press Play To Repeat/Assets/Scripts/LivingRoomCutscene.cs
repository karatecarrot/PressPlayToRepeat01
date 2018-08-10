using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivingRoomCutscene : MonoBehaviour
{
    public GameObject Player;
    public GameObject CutsceneCam;
    public GameObject Dice;
    public GameObject Trigger;
    public Text PressE;

    private void OnTriggerStay(Collider other)
    {
        PressE.text = "Press E to Look at picture";

        if (Input.GetKeyDown(KeyCode.E))
        {
            Player.SetActive(false);
            CutsceneCam.SetActive(true);
            Dice.SetActive(true);
            StartCoroutine(EndAnim());
        }
    }

    IEnumerator EndAnim()
    {
        yield return new WaitForSeconds(13.5f);
        Player.SetActive(true);
        CutsceneCam.SetActive(false);
        Dice.SetActive(false);
        Trigger.SetActive(false);
        PressE.text = " ";
    }

}
