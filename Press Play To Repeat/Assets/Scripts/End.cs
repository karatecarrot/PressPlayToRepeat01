using UnityEngine;
using System.Collections;

public class End : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        _GameManager.instance.gameText.text = "Press E to Look at Picture";
        if (Input.GetKeyDown(KeyCode.E))
        {
            _GameManager.instance.Player.SetActive(false);
            _GameManager.instance.endCamera.SetActive(true);
            //playing the hey darling diologue;
            _GameManager.instance.gameText.text = "  ";
            StartCoroutine(EndGame());
        }
    }

    private void OnTriggerExit(Collider other)
    {
        _GameManager.instance.gameText.text = "  ";
    }
    IEnumerator EndGame()
    {
        yield return new WaitForSeconds(2);
        _GameManager.instance.heyDarling.Play(0);
        yield return new WaitForSeconds(11);
        _GameManager.instance.endFade.SetActive(true);
        //playing the sigh
        _GameManager.instance.sigh.Play(0);
        yield return new WaitForSeconds(2);
        //playing the heart rate monitor.
        _GameManager.instance.heartRateMonitor.PlayDelayed(2);
        Debug.Log("Heart Rate Monitor");
       yield return new WaitForSeconds(10);

        //Quitting the game
        Application.Quit();
        Debug.Log("Quitting");
    }
}
