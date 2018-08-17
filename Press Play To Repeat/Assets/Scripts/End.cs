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
        yield return new WaitForSeconds(11);
        _GameManager.instance.endFade.SetActive(true);
        new WaitForSeconds(5);
        _GameManager.instance.heartRateMonitor.Play(0);
        Debug.Log("Heart Rate Monitor");
        new WaitForSeconds(4);
        Application.Quit();
        Debug.Log("Quitting");
    }
    
}
