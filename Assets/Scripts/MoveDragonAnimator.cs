using UnityEngine;
using System.Collections;

public class MoveDragonAnimator : MonoBehaviour {


	[SerializeField]
	private Animator _animator;
	[SerializeField]
	private GameObject _gameObject;

	private Vector3 _scaleRight = new Vector3 (-1, 1, 1);
	private Vector3 _scaleLeft = new Vector3 (1, 1, 1);

	// Update is called once per frame
	void Update () {
		float h = Input.GetAxis("Horizontal");
		_animator.SetFloat ("Fly",Mathf.Abs(h));
		if (h > 0) {
			this.transform.localScale = _scaleRight;
		} else if( h < 0) {
			this.transform.localScale = _scaleLeft;
		}
	}
}
