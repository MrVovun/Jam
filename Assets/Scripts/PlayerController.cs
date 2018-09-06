using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	[SerializeField]
	private int speed = 5;

	public bool isInNPC = false;
	public GameObject thisNPC;

	void Update () {
		Movement ();
		if (Input.GetKeyDown (KeyCode.Return) && isInNPC == true) {
			thisNPC.GetComponent<NPCController> ().myText.ActivateInputField ();
			thisNPC.GetComponent<NPCController> ().InputFieldOn = true;
		}
	}

	private void Movement () {
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate (Vector2.right * speed * Time.deltaTime);
		} else if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate (Vector2.left * speed * Time.deltaTime);
		}
	}

	private void OnTriggerEnter2D (Collider2D other) {
		if (other.tag == "NPC") {
			thisNPC = other.gameObject;
			thisNPC.GetComponent<NPCController> ().EnableCanvas ();
			isInNPC = true;
		}
	}

	private void OnTriggerExit2D (Collider2D other) {
		if (other.tag == "NPC") {
			thisNPC.GetComponent<NPCController> ().DisableCanvas ();
			thisNPC = null;
			isInNPC = false;
		}
	}

	public void DoneWithInput () {
		Debug.Log ("Ti pidor");
		thisNPC.GetComponent<NPCController> ().myText.DeactivateInputField ();
	}

}
