using UnityEngine;

public class End : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        _GameManager.instance.gameText.text = "Press E to Look at Picture";
        if (Input.GetKeyDown(KeyCode.E))
        {
            _GameManager.instance.Player.SetActive(false);
            _GameManager.instance.endCamera.SetActive(true);
        }
    }

}
