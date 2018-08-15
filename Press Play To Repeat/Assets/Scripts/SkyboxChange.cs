using UnityEngine.UI;
using UnityEngine;

public class SkyboxChange : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        _GameManager.instance.Gametext.text = "Press E to water the plants.";
        if (Input.GetKeyDown(KeyCode.E))
        {
            ChangeSkybox(_GameManager.instance.rainSkybox);
        }
    }

    public void ChangeSkybox (Material skybox)
    {
        RenderSettings.skybox = skybox;
	}
}
