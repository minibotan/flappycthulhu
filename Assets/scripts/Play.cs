using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour {
	//эта функция запускается при нажатии на кнопку "Играть!"
	public void startGame(){
		SceneManager.LoadScene("game");
	}

}
