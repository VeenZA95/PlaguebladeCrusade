using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;


public class SpawnTiles : MonoBehaviour
{
    public Sprite tileSprite;
    public Tilemap tilemap;
    public float speed;

    private List<SpriteRenderer> tiles = new List<SpriteRenderer>();

    // Start is called before the first frame update
    void Start()
    {
        // Create a row of 30 tiles from the sprite
        for (int i = 0; i < 30; i++)
        {
            GameObject tileGO = new GameObject("Tile");
            tileGO.transform.position = transform.position + new Vector3(i, 0, 0);
            SpriteRenderer tile = tileGO.AddComponent<SpriteRenderer>();
            tile.sprite = tileSprite;
            tiles.Add(tile);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Move the tiles to the left
        foreach (SpriteRenderer tile in tiles)
        {
            tile.transform.Translate(Vector2.left * speed * Time.deltaTime);
        }

        // Check if the first tile has left the screen
        if (tiles[0].transform.position.x < tilemap.localBounds.min.x)
        {
            // Destroy the first tile
            Destroy(tiles[0].gameObject);
            tiles.RemoveAt(0);

            // Add a new tile to the end of the list
            GameObject newTileGO = new GameObject("Tile");
            newTileGO.transform.position = transform.position + new Vector3(28, 0, 0);
            SpriteRenderer newTile = newTileGO.AddComponent<SpriteRenderer>();
            newTile.sprite = tileSprite;
            tiles.Add(newTile);
        }
    }
}
