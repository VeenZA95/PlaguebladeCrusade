    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{

    public GameObject playerPrefab;
    public Transform spawnPoint;
    
    // Start is called before the first frame update
    void Start()
    {
        spawnPlayer();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawnPlayer()
    {
        GameObject player = Instantiate(playerPrefab, spawnPoint.position, spawnPoint.rotation);
        // Set the player's tag to "Player" so it can be easily found by other scripts
        player.tag = "Player";
    }
}
