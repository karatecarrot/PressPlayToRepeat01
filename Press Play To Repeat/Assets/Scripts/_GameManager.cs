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

    [Space]
    [Header ("General")]
    public Text Gametext;

    [Space]
    [Header("Living Room Cutscene")]
    public GameObject Player;
    public GameObject CutsceneCam;
    public GameObject Dice;
    public GameObject Trigger;
    public Animator Picture;

}
