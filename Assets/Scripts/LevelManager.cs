using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void LoadLevel (string name){
	 	Debug.Log("Level load requested for " + name);
	 	Application.LoadLevel(name);
	}
	
	public void QuitRequest (){
		Debug.Log ("Level quit requested.");
		Application.Quit();
	}
	
	public void BackToStart(string name){
	Debug.Log ("Back button pressed.");
	Application.LoadLevel(name);
	}

	public void LoadNextLevel(){
	Application.LoadLevel(Application.loadedLevel + 1);
	}

	public void BrickDestroyed(){
	if (Brick.brickCount <= 0){
		LoadNextLevel();
	}

	}
}
