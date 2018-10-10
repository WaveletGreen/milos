using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScenes : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void onStartGame(string sceneName) {
        //切换场景
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
        //GameObject canvas = FindSceneObjectsOfType("s1_ui");
    }
}
