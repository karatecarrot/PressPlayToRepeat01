using UnityEngine.UI;
using System.Collections;
using UnityEngine;

public class SkyboxChange : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if (_GameManager.instance.raining == false) // checking if the rain has started prevnting the player from starting it more than once.
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

    private void Update()
    {
        // changing the intensity of the light to make to look more gloomy when raining.
        if (_GameManager.instance.raining == true)
        {
            if (_GameManager.instance.DirectionalLight.intensity >= 0.5f)
                _GameManager.instance.DirectionalLight.intensity -= Time.deltaTime;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        _GameManager.instance.gameText.text = " ";
    }

    public void ChangeSkybox (Material skybox)
    {
        // setting the skybox
        RenderSettings.skybox = skybox;
	}
}
