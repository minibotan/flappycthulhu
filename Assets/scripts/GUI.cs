using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUI : MonoBehaviour {
	//гейм обжект текста где отображаются наши очки
	public GameObject text;
	// тут сам текст
	private Text t;
	// за такое время + Wtime секунд первая стена проходит под ктулху
	private float startTime;

	// время между спавном стен
	private float Wtime;

	void Start(){
		startTime = config.STIME;
		Wtime = config.WTIME;


		//тут мы получаем компонент текста куда и будем писать счет
		t = text.GetComponent<Text>();
	}
	void OnGUI()
	{	
		// не хитрая формула которая считает счет в зависимости от времени
		// которое прошло с начала загрузки сцены
		// описывать формулу бесполезно если знать что это за переменные
		// а берем максимум от формулы и 0 для того, чтоб не было отрицательного счета в самом начале.
		int score =  Mathf.Max(Mathf.FloorToInt((Time.timeSinceLevelLoad - startTime)/Wtime) + 1, 0);
		t.text = score.ToString();
	}
}
