using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using System.Collections;
//using Exploder;

namespace Exploder.Demo
{
    public class DemoSimple : MonoBehaviour
    {
        public ExploderObject Exploder;
        public GameObject[] DestroyableObjects;
		public GameObject gameObject;

        private void Start()
        {

			gameObject = GameObject.Find("Sphere");
//			gameObject = GameObject.Find("Sphere100");


//			Exploder = Utils.ExploderSingleton.Instance;
			Exploder = gameObject.GetComponent<ExploderObject>();
//			Exploder = GetComponent( typeof(ExploderObject) ) as ExploderObject;
//			Exploder = GetComponent<ExploderObject>();


			Debug.Log ("hoge0");
			Debug.Log (Exploder);

//			if (Exploder.DontUseTag)
			if (false)
            {
                var objs = FindObjectsOfType(typeof (Explodable));
                var objList = new List<GameObject>(objs.Length);
                objList.AddRange(from Explodable ex in objs where ex select ex.gameObject);
                DestroyableObjects = objList.ToArray();
            }
            else
            {
                // find all objects in the scene with tag "Exploder"
                DestroyableObjects = GameObject.FindGameObjectsWithTag("Exploder");
            }
        }

        private void OnGUI()
        {
            if (GUI.Button(new Rect(10, 10, 100, 30), "Explode!"))
            {

				Debug.Log ("hoge1");
				Debug.Log (Exploder);

                if (Exploder)
                {
					Debug.Log ("hoge2");
                    Exploder.ExplodeRadius();
                }
            }

            if (GUI.Button(new Rect(130, 10, 100, 30), "Reset"))
            {
                // activate exploder
                ExploderUtils.SetActive(Exploder.gameObject, true);

                if (!Exploder.DestroyOriginalObject)
                {
                    foreach (var destroyableObject in DestroyableObjects)
                    {
                        ExploderUtils.SetActiveRecursively(destroyableObject, true);
                    }
                    ExploderUtils.SetActive(Exploder.gameObject, true);
                }
            }
        }
    }
}
