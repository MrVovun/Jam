using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NPCController : MonoBehaviour {
	public Canvas myCanvas;
	public TMP_InputField myText;
	public bool InputFieldOn = false;

	public void EnableCanvas () {
		myCanvas.gameObject.SetActive (true);
	}

	public void DisableCanvas () {
		myCanvas.gameObject.SetActive (false);
	}
}
