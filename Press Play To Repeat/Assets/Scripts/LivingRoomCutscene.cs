using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivingRoomCutscene : MonoBehaviour
{
    public GameObject Player;
    public GameObject CutsceneCam;
    public GameObject Dice;
    public GameObject Trigger;

    private void OnTriggerEnter(Collider other)
    {
        Player.SetActive(false);
        CutsceneCam.SetActive(true);
        Dice.SetActive(true);
        StartCoroutine(EndAnim());
    }

    IEnumerator EndAnim()
    {
        yield return new WaitForSeconds(13.5f);
        Player.SetActive(true);
        CutsceneCam.SetActive(false);
        Dice.SetActive(false);
        Trigger.SetActive(false);
    }

}
