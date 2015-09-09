using UnityEngine;
using System.Collections;

public class coroutine : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		StartCoroutine (WaitAndPrint());
		Debug.Log("Hello" + Time.time);
		StartCoroutine (Example());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	IEnumerator WaitAndPrint() {
		yield return new WaitForSeconds(5f);
		print("WaitAndPrint " + Time.time);
	}
	IEnumerator Example() {
		print("Starting " + Time.time);
		yield return WaitAndPrint();
		yield return new WaitForSeconds(7f);
		print("Done " + Time.time);
		Debug.Log("Hello" + Time.time);
		yield return new WaitForSeconds(10);
		Application.LoadLevel("2");
	}
	
	
}

