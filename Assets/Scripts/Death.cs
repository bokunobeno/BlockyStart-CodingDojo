using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Death : MonoBehaviour
{
	[SerializeField] string sceneName;
	[SerializeField] string tagID;

	void OnTriggerEnter(Collider collider){
		if(collider.gameObject.CompareTag(tagID)){
			SceneManager.LoadScene(sceneName);
		}
	}
}
