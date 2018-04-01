using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour {

	private Animator _animator;
	private CanvasGroup _canvasGroup;

	public bool ISOpen {
		get { return _animator.GetBool ("ISOpen"); }
		set { _animator.SetBool ("ISOpen",value); }
	}

	public void Awake(){
		_animator = GetComponent<Animator>();
		_canvasGroup = GetComponent<CanvasGroup>();


		var rect = GetComponent<RectTransform>();
		rect.offsetMax = rect.offsetMin = new Vector2 (0, 0);
	}

	public void Update(){
		if (!_animator.GetCurrentAnimatorStateInfo (0).IsName ("Open")) {
			_canvasGroup.blocksRaycasts = _canvasGroup.interactable = false;
		} 
		else {
			_canvasGroup.blocksRaycasts = _canvasGroup.interactable = true;

		}
	}
}
