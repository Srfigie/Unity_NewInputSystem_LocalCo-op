using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LevelInitializer : MonoBehaviour
{
    [SerializeField]
    private Transform[] PlayerSpawns;

    [SerializeField]
    private GameObject playerPrefab;
    // Start is called before the first frame update
    void Start()
    {
        var playerConfigs = PlayerConfigurationManager.GetPlayerConfigs().ToArray();
        for (int i = 0; i < playerConfigs.Length; i++)
        {
            var player = Instantiate(playerPrefab, PlayerSpawns[i].position, PlayerSpawns[i].rotation, gameObject.transform);
            player.GetComponent<PlayerInputHandler>().InitializePlayer(playerConfigs[i]);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
