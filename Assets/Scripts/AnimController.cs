using UnityEngine;
using System.Collections;

public class AnimController : MonoBehaviour {

	[SerializeField]
	private Animator _animator;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			_animator.SetTrigger ("Fire");
		}
	}
}
