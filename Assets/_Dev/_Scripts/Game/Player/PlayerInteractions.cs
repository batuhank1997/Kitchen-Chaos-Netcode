using Unity.Netcode;
using UnityEngine;

public class PlayerInteractions : NetworkBehaviour
{
    [SerializeField] private Transform spawnObjectPrefab;
    
    private Vector3 lastInteractDir;
    
    private void Start()
    {
        GameInput.OnInteractAction += OnInteractAction;
        GameInput.OnShootAction += OnShootAction;
    }

    private void OnShootAction()
    {
        Debug.Log("On Shoot Invoked!");
    }

    private void OnInteractAction()
    {
        Debug.Log("On Interact Invoked!");
        
        var spawnedObj = Instantiate(spawnObjectPrefab);
        spawnedObj.GetComponent<NetworkObject>().Spawn(true);

        /*Vector2 inputVector = GameInput.I.GetMovementVectorNormalized();

        var moveDir = new Vector3(inputVector.x, 0, inputVector.y);

        if (moveDir != Vector3.zero)
            lastInteractDir = moveDir;

        var interactDistance = 2f;

        if (Physics.Raycast(transform.position, lastInteractDir, out RaycastHit hitInfo, interactDistance)) 
        {
            Debug.Log(hitInfo.collider.name);
        }*/
    }
}
