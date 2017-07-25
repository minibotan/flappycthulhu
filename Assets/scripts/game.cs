using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game : MonoBehaviour {
	

	// таймер до появления следующей стенки
	private float nextTimer;
	// время между появлениями стен
	private float Wtimer;

	// сама стена
	public GameObject wall;

	// максимальная высота стены
	private float maxh;

	// минимальная высота стены
	private float minh;

	// размер стены
	private float size;

	// Use this for initialization
	void Start () {
		nextTimer = 0;
		Wtimer = config.WTIME;
		minh = config.WALL_MIN_H;
		maxh = config.WALL_MAX_H;
		size = config.WALL_SIZE;

		// в основном, это надо для продолжения игры после проигрыша.
		Time.timeScale = 1;
	}
	
	// Update is called once per frame
	void Update () {

		// уменьшаем время до появления следующей стены
		nextTimer -= Time.deltaTime;

		// если время до появления стены кончилось - ставим стену
		if(nextTimer < 0) {

			// создаем новую копию стены
			GameObject newWall = Instantiate(wall, new Vector2(), new Quaternion());
			// вычисляем высоту стены
			float r = Random.Range(minh, maxh);
			// вытаскиваем спрайт рендерер чтоб настроить размер стены
			SpriteRenderer sr = newWall.GetComponent<SpriteRenderer>();
			// выставляем размеры
			sr.size = new Vector2(size, r*size);
			//перемещаем стену на позицию, где она должна появиться
			newWall.transform.position = new Vector2(10f, r);
			// обновляем время до появления следующей копии.
			nextTimer = Wtimer;
		}
	}
}
