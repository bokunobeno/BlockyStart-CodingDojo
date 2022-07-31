using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
	[SerializeField] private string _tagID = "Player";
	[SerializeField] private string _sceneName;


	private void OnTriggerEnter(Collider _collider){
		if(_collider.gameObject.CompareTag(_tagID)){
			SceneManager.LoadScene(_sceneName);
		}
	}
}
