using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordManager : MonoBehaviour {

	// A list to store all the Word objects
	public List<Word> words;// A list to store all the Word objects

    // A reference to the WordSpawner script
    public WordSpawner wordSpawner;

	// A boolean to keep track of whether there is an active Word object
	private bool hasActiveWord;

    // The active Word object
	private Word activeWord;


    // This method is called by other scripts to add a new Word object to the list
    public void AddWord ()
	{
		// Generate a random word using the WordGenerator class and spawn it using the WordSpawner script
		Word word = new Word(WordGenerator.GetRandomWord(), wordSpawner.SpawnWord());
		Debug.Log(word.word);

		// Add the new Word object to the list
		words.Add(word);
	}
    
	// This method is called by other scripts to input a letter
	public void TypeLetter (char letter)
	{
		if (hasActiveWord)  // If there is an active Word object
		{
			if (activeWord.GetNextLetter() == letter)  // If the next letter matches the input letter
			{
				activeWord.TypeLetter();  // Type the letter in the active Word object
			}

		} 
		else // If there is no active Word object
		{
			foreach(Word word in words)  // Check all the Word objects in the list
			{
				if (word.GetNextLetter() == letter)  // If the next letter matches the input letter
				{
					activeWord = word;  // Set this Word object as the active one
					hasActiveWord = true;
					word.TypeLetter();  // Type the letter in the Word object
					break;  // Exit the loop
				}
			}
		}

		if (hasActiveWord && activeWord.WordTyped())  // If there is an active Word object and it has been fully typed
		{
			hasActiveWord = false;  // Reset the boolean flag
			words.Remove(activeWord);  // Remove the Word object from the list
		}
	}
	

}
