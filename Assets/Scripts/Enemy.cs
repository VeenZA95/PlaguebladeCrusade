using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    public List<Sprite> enemies;

    public Sprite enemysprite;

    public Sprite SelectRandomEnemySprite()
    {
        Debug.Log("Sprite Selected");
        return enemies[Random.Range(0, 1)];
    }

}
