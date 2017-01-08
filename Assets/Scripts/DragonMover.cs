using UnityEngine;
using System.Collections;

public class DragonMover : MonoBehaviour {
	[SerializeField]
	private Rigidbody2D _rigBody;
	[SerializeField]
	private float _flySpeed=1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		var move =new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"),0);
		transform.position += move*Time.deltaTime*_flySpeed;
	
	}
}
