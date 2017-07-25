using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	// за такое время + Wtime секунд первая стена проходит под ктулху
	private float startTime;

	// время между спавном стен
	private float Wtime;

	private Text text;
	void Start(){
		startTime = config.STIME;
		Wtime = config.WTIME;

		text = this.GetComponent<Text>();
	}

	// Update is called once per frame
	void Update () {
		int score =  Mathf.Max(Mathf.FloorToInt((Time.timeSinceLevelLoad - startTime)/Wtime) + 1, 0);
		text.text = score.ToString();
	}
}
