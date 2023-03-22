using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSpawner : MonoBehaviour {

	public GameObject wordPrefab;
	public Transform wordCanvas;

	
	[SerializeField]
	public GameObject enemyManager;

	public WordDisplay SpawnWord ()
	{
		Vector3 randomPosition = new Vector3(10f, 0.1f);

		GameObject wordObj = Instantiate(wordPrefab, randomPosition, Quaternion.identity, wordCanvas);

		WordDisplay wordDisplay = wordObj.GetComponent<WordDisplay>();
		Debug.Log("Sprite randomiser called");
		wordObj.GetComponent<SpriteRenderer>().sprite = enemyManager.GetComponent<Enemy>().enemies[Random.Range(0, 2)];
		
		return wordDisplay;
	}

}
