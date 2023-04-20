using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCounter : MonoBehaviour
{
    [SerializeField] private KitchenObjectSO kitchenObjectSo;
    [SerializeField] private Transform spawnTransform;
    
    public void Interact()
    {
        var kitchenObj = Instantiate(kitchenObjectSo.prefab, spawnTransform.position, Quaternion.identity);

        Debug.Log(kitchenObj.GetKitchenObject);
    }
}
