using UnityEngine;
using System.Collections;

public class DeathGUI : MonoBehaviour {
	const int IMG_SIZE = 512;
	
	public Texture death_texture;
	public Texture death_texture2;
	
	int width, height;
	int part1, part2;

	void Awake()
	{
		width = Screen.width;
		height = Screen.height;
		part1 = width/2-height/2;
		part2 = part1+height;
	}

	void OnGUI()
	{
		GUI.DrawTexture(new Rect(part1,0,height,height),death_texture);
		GUI.DrawTexture(new Rect(0,0,part1,height),death_texture2);
		GUI.DrawTexture(new Rect(part2,0,width-part2,height),death_texture2);
	}
}
