using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NPCController : MonoBehaviour {
	public Canvas myCanvas;
	public TextMeshProUGUI myText;

	public void EnableCanvas () {
		myCanvas.gameObject.SetActive (true);
	}

	public void DisableCanvas () {
		myCanvas.gameObject.SetActive (false);
	}
}
