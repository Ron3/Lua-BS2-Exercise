using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonLogic : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject button = GameObject.Find("Button");
		Button btn = button.GetComponent<Button>();
		btn.onClick.AddListener( delegate() {
			this.OnBtnClick(button);
		});
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	/// <summary>
	/// 
	/// </summary>
	/// <param name="btn"></param>
	public void OnBtnClick(GameObject btn)
	{
		Debug.Log("OnBtnClick ===> by Ron");
	}

}
