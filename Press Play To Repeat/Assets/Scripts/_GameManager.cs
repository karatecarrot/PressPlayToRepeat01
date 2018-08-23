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

    public Text gameText;
    [Header("Skybox")]
    public Material rainSkybox;
    public GameObject rain;
    public bool raining;
    public Light DirectionalLight;
    public Animator Tap;
    public bool checkpoint1;

    [Header("Bedroom")]
    public GameObject endTrigger;
    public GameObject endCamera;
    public GameObject endFade;

    [Header("Living Room Cutscene")]
    public GameObject Player;
    public GameObject cutsceneCam;
    public GameObject Dice;
    public GameObject Trigger;
    public Animator Picture;
    public GameObject Grandson;
    public bool checkpoint2;

    [Header("Breakfast")]
    public GameObject Plate;
    public GameObject Dishes;
    public AudioSource plateOnTable;
    public bool Eaten;
    public GameObject sitDown;
    public GameObject breakfastTrigger;
    public Animator cupboard;
    public bool checkpoint3;

    [Header("Sit")]
    public GameObject sitcam;
    public bool isSitting;
    public bool checkpoint4;
    
    public GameObject Plate2;
    public GameObject foodCamera;

    [Header("Dishes")]
    public GameObject washingUp;
    public bool Teleported;
    public bool checkpoint5;
    
    [Header ("Audio")]
    public AudioSource whatAmIDoing;
    public AudioSource howdThatGet;
    public AudioSource whydIComeHere;
    public AudioSource heartRateMonitor;
    public AudioSource heartDiologue;
    public AudioSource sigh;
    public AudioSource heyTom;
    public AudioSource heyDarling;
    public float diologueDelay;

    private void Update()
    {
        if (checkpoint1 == true && checkpoint2 == true && checkpoint3 == true && checkpoint4 == true && checkpoint5 == true)
        {
            Debug.Log("End Activated");
            endTrigger.SetActive(true);
        }
    }

    private void Start()
    {
        StartCoroutine(Hospital());
        Debug.Log("heart rate monitor in 30 sec");
    }
    IEnumerator Hospital()
    {
        yield return new WaitForSeconds(30);
        heartRateMonitor.Play(0);
        new WaitForSeconds(diologueDelay);
        heartDiologue.Play(0);
    }
}