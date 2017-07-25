using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class config : MonoBehaviour {
	//время до того как первая стена доедет до ктулху
	public static float STIME = 3.5f;
	// время между спавном стен
	public static float WTIME = 2f;
	// скорость стен
	public static float SPEED = -4f;
	//сила с которой толкаем ктулху вверх
	public static float FORCE = 5f;
	//макс высота стены
	public static float WALL_MAX_H = 5f;
	//мин высота стены
	public static float WALL_MIN_H = 3f;
	//размер стены(коэфициент толщины и высоты)
	public static float WALL_SIZE = 2f;
}
