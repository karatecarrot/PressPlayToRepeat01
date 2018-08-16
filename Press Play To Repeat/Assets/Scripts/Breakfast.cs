﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakfast : MonoBehaviour
{
    public void OnTriggerStay(Collider other)
    {
        if (_GameManager.instance.Eaten == false)
        {
            _GameManager.instance.gameText.text = "Press E to Make Breakfast";
            if (Input.GetKeyDown(KeyCode.E))
            {
                _GameManager.instance.Plate.SetActive(true);
                _GameManager.instance.Dishes.SetActive(true);
                _GameManager.instance.plateOnTable.Play(1);
                _GameManager.instance.sitDown.SetActive(true);
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        _GameManager.instance.gameText.text = " ";
    }
}
