using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

	public Sprite[] hitSprites;
	public static int brickCount = 0;
	private bool isBreakable;

	private int timesHit;
	private LevelManager levelManager;



	// Use this for initialization
	void Start () {
		 timesHit = 0;
		 isBreakable = (this.tag == "Breakable");

		 if (isBreakable){
		 brickCount++;
		 print (brickCount);
		 }
		 levelManager = GameObject.FindObjectOfType<LevelManager>();

		
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnCollisionEnter2D (Collision2D col){

		if (isBreakable){
				HandleHits();
		}

	}

	void HandleHits(){

		timesHit++;

	int maxHits = hitSprites.Length + 1;
	if(this.timesHit >= maxHits){
		brickCount--;
		print (brickCount);
	 	Destroy(gameObject);
	 }else{
		 LoadSprites();
	 }

	}

	void LoadSprites(){
		int spriteIndex = timesHit - 1;
		if (hitSprites[spriteIndex]){
		this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
		}
	}




}
