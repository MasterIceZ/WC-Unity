using System.Collection;
using System.Collection.Generic;
using UnityEngine;

/*
 * Develop by Icelnwza007
 * How to use this code
 *  - What you should do with this code is input the numbers in you Unity Project
 *  - You should create the object out of the real map that means you should create the object that you want to generate in the other platform!
 *  - Any problem? Ask Ice How this code run!!
 * */

public class Gen_Item : MonoBehaviour
{
	public int end = 5;
	public List <GameObject> Ob;
	public int secs;
	//Can change datatype here
	public int stx,enx,sty,eny,stz,enz;
	void Start()
	{
		StartCoroutinr(SpawnRate());
	}

	void Update()
	{
		int n;

		
	}
	private bool LoopRunner = true;
	IEnumerator SpawnRate ()
	{
		while(LoopRunner)
		{
			yield return new WaitForSeconds(secs);
			Instatiate(Items[Random.Range(0,end)],new Vector3(Random.Range(stx,enx),Random.Range(sty,eny),Random.Range(stz,enz)),Quaternion.identity);
		}
	}
}
