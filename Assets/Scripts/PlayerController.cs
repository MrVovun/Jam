using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	[SerializeField]
	private int speed = 5;

	public bool isInNPC = false;
	public GameObject thisNPC;

	public Canvas myCanvas;
	public TextMeshProUGUI myText;

	void Update () {
		Movement ();
		if (Input.GetKeyDown (KeyCode.Space) && isInNPC == true) {
			thisNPC.GetComponent<NPCController> ().EnableCanvas ();
		}
	}

	private void Movement () {
		if (Input.GetKey (KeyCode.D)) {
			transform.Translate (Vector2.right * speed * Time.deltaTime);
		} else if (Input.GetKey (KeyCode.A)) {
			transform.Translate (Vector2.left * speed * Time.deltaTime);
		}
	}

	private void OnTriggerEnter2D (Collider2D other) {
		if (other.tag == "NPC") {
			thisNPC = other.gameObject;
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

}
