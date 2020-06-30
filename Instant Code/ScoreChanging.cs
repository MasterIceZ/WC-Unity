using System.Collection;
using System.Collection.Generic;
using UnityEngine;
using UnityEngine.UI;
/*
 * Develop By Icelnwza--7
 *  -Change Score From Int to string
 *  -Use the score as static to use in golbla file 
 * */
public class ScoreChanging : MonoBehaviour
{
	public Text ScoreStr;
	static public int Score;
	void Start()
	{
		Score = 0;
		ScoreStr.text = "";
	}

	void Update()
	{
		ScoreStr.text = "" + score;
	}
	
	private bool temp = false;

	void ChangeScore()
	{
		/*
		 * Enter Your Case to get Score here!!
		 * */
		if(temp)
		{
			Score+=1;
		}
	}	
}
