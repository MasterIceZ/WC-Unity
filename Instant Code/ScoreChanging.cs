using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/*
 * Develop By Icelnwza--7
 *  -Change Score From Int to string
 *  -Use the score as static to use in golbla file 
 * */
public class ScoreChanging : MonoBehaviour
{
    public static int ScoreValue = 0;
    public Text Score;
	void Start()
	{
		//ScoreValue = GetComponent<Text>();
	}

	void Update()
	{
		ChangeScore();
		
		Debug.Log(ScoreValue);
	}
	
	private bool temp = false;

    void ChangeScore()
	{
		/*
		 * Enter Your Case to get Score here!!
		 * */
		if(temp)
		{
			ScoreValue+=1;
		}
	}	
}
