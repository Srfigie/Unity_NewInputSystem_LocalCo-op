using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.UI;

public class SpawnPlayerSetupMenu : MonoBehaviour
{
    public GameObject playerSetupMenuPrefab;

    private GameObject rootMenu;
    public PlayerInput input;

    private void Awake()
    {
        rootMenu = GameObject.Find("MainLayout");
        var menu = Instantiate(playerSetupMenuPrefab, rootMenu.transform);
        input.uiInputModule = menu.GetComponentInChildren<InputSystemUIInputModule>();
        menu.GetComponent<PlayerSetupMenuController>().setPlayerIndex(input.playerIndex);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
