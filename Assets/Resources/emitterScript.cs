using UnityEngine;
using System.Collections;

public class emitter : MonoBehaviour {
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
			Color ren_color = GetComponent<Renderer>().material.color;
			switch(Random.Range(0,3)){

			case 0: ren_color = Color.red; break;
			case 1: ren_color = Color.blue; break;
			case 2: ren_color = Color.green; break;
			case 3: ren_color = Color.magenta; break;
			}
		}
	}
}