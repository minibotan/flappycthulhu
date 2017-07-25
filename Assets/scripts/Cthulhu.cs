using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cthulhu : MonoBehaviour {
	public GameObject panel;
	private float force;
	Rigidbody2D rb;
	// Use this for initialization
	void Start () {
		force = config.FORCE;

		//тут получаем ригидбоди ктулху для того, чтоб потом его подталкивать вверх
		rb = this.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.y < 0) {   // если ктулху упал - гг
			endGame();
		}

		//тут проверка на нажатие
		if(Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.J) || Input.GetTouch(0).phase == TouchPhase.Began) {

			//если игра остановлена, то после нажатия нужно начать заново
			//написано прям тут чтоб не проверять на нажание во всех классах
			if(Time.timeScale < 0.1) { 
				newGame();
			}

			// толкаем ктулху ввехр, если было нажатие
			rb.velocity = transform.up * force;
		}
	}


	// если воткнулся в стену - гг
	// стены единственный триггер в игре
	void OnTriggerEnter2D(Collider2D other){  
		endGame();
	}
	


	//собственно, останавливаем время и выводим сообщение что мы проиграли.
	void endGame(){
		Time.timeScale = 0;
		panel.SetActive(true);
	}


	// тут я решил просто заново загрузить сцену для начала новой игры.
	void newGame(){
		SceneManager.LoadScene("game");
	}

}
