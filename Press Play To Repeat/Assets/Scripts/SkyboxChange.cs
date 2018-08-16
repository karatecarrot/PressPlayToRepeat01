using UnityEngine.UI;
using System.Collections;
using UnityEngine;

public class SkyboxChange : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if (_GameManager.instance.raining == false)
        {
            _GameManager.instance.gameText.text = "Press E to water the plants.";
            if (Input.GetKeyDown(KeyCode.E))
            {
                ChangeSkybox(_GameManager.instance.rainSkybox);
                _GameManager.instance.rain.SetActive(true);
                _GameManager.instance.raining = true;
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        _GameManager.instance.gameText.text = " ";
    }

    public void ChangeSkybox (Material skybox)
    {
        RenderSettings.skybox = skybox;
	}
}
