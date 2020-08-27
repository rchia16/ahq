using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public string SceneName;
    // Start is called before the first frame update
    public void OnClick()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(SceneName);
        Debug.Log("Hello I am changing scene");
    }
}
