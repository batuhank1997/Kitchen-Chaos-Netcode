using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/KitchenObjects/new KitchenObject", fileName = "KitchenObject")]
public class KitchenObjectSO : ScriptableObject
{
    public KitchenObject prefab;
    public Sprite sprite;
    public string objectName;
}
