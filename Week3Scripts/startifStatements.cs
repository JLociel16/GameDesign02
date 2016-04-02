using UnityEngine;
using System.Collections;

public class startifStatements : MonoBehaviour {

	public bool fact = true;
	// Use this for initialization
	void Start () {
		if (fact == true) {
			fact = false;
			if(fact == false) {
				Debug.Log ("Fact was switched to False");
			} else{
				Debug.Log ("ERROR");
			}
		} else {
			Debug.Log ("Condition wasn't met");
		}

//		if (10 < 20) {
//			Debug.Log (3+4*5+1);
//		}
		//Multi If Statement
//		if (fact == true) {
//			Debug.Log (fact);
//		}
//		if (5 < 20) {
//			fact = false;
//			Debug.Log ("False");
//		}
		//Standard IfElse Statement
//		if (10 < 20) {
//			Debug.Log (3+4*5+1);
//		}
//		else {
//			Debug.Log (1*8+(10-5));
//		}
	}
	
//	// Update is called once per frame
//	void Update () {
//	
//	}
}
