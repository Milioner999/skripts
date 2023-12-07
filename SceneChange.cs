using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;


public class SceneChange : MonoBehaviour
{
    public string SceneName;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        EditorSceneManager.LoadScene(SceneName);
    }

}   