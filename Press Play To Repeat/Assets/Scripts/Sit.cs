﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sit : MonoBehaviour
{
    public Transform TeleportTo;
    private void OnTriggerStay(Collider other)
    {
        _GameManager.instance.gameText.text = "Press E to eat";
        if (Input.GetKeyDown(KeyCode.E) && _GameManager.instance.isSitting == false)
        {
            //starting the sitting animation.
            _GameManager.instance.Player.SetActive(false);
            _GameManager.instance.sitcam.SetActive(true);
            _GameManager.instance.Plate.SetActive(false);
            _GameManager.instance.Plate2.SetActive(true);
            _GameManager.instance.gameText.text = "  ";
            _GameManager.instance.isSitting = true;
            //Playing "Oh, now how’d that get over there?"
            _GameManager.instance.howdThatGet.Play(0);
            StartCoroutine(KitchenAnim());
        }
    }
    IEnumerator KitchenAnim()
    {
        yield return new WaitForSeconds(12.2f);
        _GameManager.instance.Player.transform.position = TeleportTo.position;
        _GameManager.instance.Player.SetActive(true);
        _GameManager.instance.sitcam.SetActive(false);
        _GameManager.instance.Plate2.SetActive(false);
        _GameManager.instance.sitDown.SetActive(false);
        _GameManager.instance.checkpoint4 = true;
    }

}
