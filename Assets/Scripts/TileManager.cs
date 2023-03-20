using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileManager : MonoBehaviour
{
    public List<TileBase> tileList;
    public Tilemap tilemap;
    public int tileCount;

    void Start()
    {
        CreateRow();
    }

    void CreateRow()
    {
        Vector3Int startPosition = new Vector3Int(-11, -5, 0);
        for (int i = 0; i < tileCount; i++)
        {
            Vector3Int position = new Vector3Int(startPosition.x + i, startPosition.y, startPosition.z);
            tilemap.SetTile(position, tileList[i % tileList.Count]);
        }
    }
}
    