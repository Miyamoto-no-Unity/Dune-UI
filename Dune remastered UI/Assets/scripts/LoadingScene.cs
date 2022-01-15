using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingScene : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(LoadCor());
    }

   IEnumerator LoadCor()
   {
    yield return new WaitForSeconds(3);
    SceneManager.LoadScene(1);

   }
}
