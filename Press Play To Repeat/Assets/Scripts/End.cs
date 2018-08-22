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
            _GameManager.instance.heyDarling.Play(0);
            //playing the hey darling diologue;

            _GameManager.instance.sigh.PlayDelayed(4);
            //playing the sigh
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
        yield return _GameManager.instance.heyDarling;
        new WaitForSeconds(11);
        _GameManager.instance.endFade.SetActive(true);

        //playing the sigh
        _GameManager.instance.sigh.Play(0);
        new WaitForSeconds(5);

        //playing the heart rate monitor.
        _GameManager.instance.heartRateMonitor.PlayDelayed(2);
        Debug.Log("Heart Rate Monitor");
        new WaitForSeconds(5);

        //Quitting the game
        Application.Quit();
        Debug.Log("Quitting");
    }
}
