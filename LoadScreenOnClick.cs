using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneMangement;

public class LoadScreenOnClick : MonoBehaviour {

	public void LoadByIndex(int sceneIndex){
			SceneManger.LoadScene(sceneIndex);
	}
}
