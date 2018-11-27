using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 

public class SceneSwitch : MonoBehaviour
{
    public void SceneSwitcher ()
    {
        SceneManager.LoadScene(1);
    }
}
