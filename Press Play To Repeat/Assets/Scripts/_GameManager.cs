using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _GameManager : MonoBehaviour
{

    #region Singleton
    public static _GameManager instance;

    private void Awake()
    {
        instance = this;

        if (instance != this)
            Destroy(gameObject);
    }
    #endregion

    [Header("Skybox")]
    public Material rainSkybox;
    public GameObject rain;
    public bool raining;
    public Light DirectionalLight;

    [Space]
    [Header ("General")]
    public Text gameText;

    [Space]
    [Header("Living Room Cutscene")]
    public GameObject Player;
    public GameObject cutsceneCam;
    public GameObject Dice;
    public GameObject Trigger;
    public Animator Picture;
    public GameObject Grandson;

    [Space]
    [Header("Breakfast")]
    public GameObject Plate;
    public GameObject Dishes;
    public AudioSource plateOnTable;
    public bool Eaten;
    public GameObject sitDown;

    [Space]
    [Header ("sitting")]
    public GameObject Plate2;
    public GameObject foodCamera;

    [Space]
    [Header("Sit")]
    public GameObject sitcam;    
}