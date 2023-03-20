using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class SpawnTiles : MonoBehaviour
{
    public GameObject tilePrefab;
    public Tilemap tilemap;
    public float speed;

    private List<GameObject> tiles = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        // Create a row of 30 tiles from the prefab
        for (int i = 0; i < 30; i++)
        {
            GameObject tile = Instantiate(tilePrefab, transform.position + new Vector3(i, 0, 0), Quaternion.identity);
            tiles.Add(tile);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Move the tiles to the left
        foreach (GameObject tile in tiles)
        {
            tile.transform.Translate(Vector2.left * speed * Time.deltaTime);
        }

        // Check if the first tile has left the screen
        if (tiles[0].transform.position.x < tilemap.localBounds.min.x)
        {
            // Destroy the first tile
            Destroy(tiles[0]);
            tiles.RemoveAt(0);

            // Add a random tile from the prefab to the end of the list
            GameObject newTile = Instantiate(tilePrefab, transform.position + new Vector3(29, 0, 0), Quaternion.identity);
            tiles.Add(newTile);
        }
    }
}