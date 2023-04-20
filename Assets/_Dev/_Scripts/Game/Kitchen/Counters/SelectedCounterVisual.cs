using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedCounterVisual : MonoBehaviour
{
    [SerializeField] private ClearCounter clearCounter;
    [SerializeField] private GameObject visualGameObject;
    
    
    private void Awake()
    {
        PlayerController.I.PlayerInteractions.OnSelectedCounterChanged += OnSelectedCounterChanged;
    }

    private void OnSelectedCounterChanged(ClearCounter _clearCounter)
    {
        if (_clearCounter == clearCounter)
            Show();
        else
            Hide();
    }

    void Show()
    {
        visualGameObject.SetActive(true);
    }
    
    void Hide()
    {
        visualGameObject.SetActive(false);
    }
}
