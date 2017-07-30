using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class emitterScripts : MonoBehaviour {
	// 複製するPrefabをobjにInspector格納しておく
	public GameObject obj;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// マウスが左クリックされたら以下を実行
		if(Input.GetMouseButtonDown(0)){
			// ゲームオブジェクトを複製
			// 戻り値はObjectクラスなので、必ず複製したオブジェクトと同じクラスへキャストする

			GameObject instance = (GameObject)Instantiate(obj);
			// 複製したオブジェクトの位置をemmitterオブジェクトと同じ位置へ
			instance.transform.position = gameObject.transform.position;
			// 色をランダムで変更
			Debug.Log(instance.GetComponent<Renderer>().material.color);
			switch(Random.Range(0,3)){

			case 0: instance.GetComponent<Renderer>().material.color = Color.red; break;
			case 1: instance.GetComponent<Renderer>().material.color = Color.blue; break;
			case 2: instance.GetComponent<Renderer>().material.color = Color.green; break;
			case 3: instance.GetComponent<Renderer>().material.color = Color.magenta; break;
			}
		}
		
	}
}
