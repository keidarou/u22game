//端末の加速度から
//あとで実機テストします
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetAcc : MonoBehaviour {

	private Vector3 acc;//端末の加速度
	//フォントでばっぐよう
	private GUIStyle labelStyle;
	//関数の返り値
	public int ret;

	// Use this for initialization
	void Start () {
		//フォントさくせい
		this.labelStyle=new GUIStyle();
		this.labelStyle.fontSize = Screen.height / 20;
		this.labelStyle.normal.textColor=Color.blue;
		
	}
	
	// Update is called once per frame
	void Update () {
		this.acc = Input.acceleration;

		if (acc.x < 0) {
			if (acc.y < 0)
				ret = 0;
			else
				ret = 1;
		} else {
			if (acc.y < 0)
				ret = 2;
			else 
				ret = 3;

		}

	}
	//GUIこうしん(デバックじ以外はコメントアウトで)
	void OnGUI(){
		if (acc != null) {
			float x = Screen.width / 10;
			float y = 0;
			float w = Screen.width * 8 / 10;
			float h = Screen.height / 20;

			for (int i = 0; i < 4; i++) {
				y = Screen.height / 10 + h * i;
				string text = string.Empty;

				switch (i) {
					
				case 0:
					text = string.Format ("x:{0}", System.Math.Round (this.acc.x, 3));
					break;
				case 1:
					text = string.Format ("y:{0}", System.Math.Round (this.acc.y, 3));
					break;
				case 2:
					text = string.Format ("z:{0}", System.Math.Round (this.acc.z, 3));
					break;
				case 3:
					text = string.Format ("D:{0}", ret);
					break;
				default:
					throw new System.InvalidOperationException ();
						
				}
				GUI.Label (new Rect (x, y, w, h), text, this.labelStyle);

			}
		}
	}

	int getDirection(){
		return ret;
	}


}


