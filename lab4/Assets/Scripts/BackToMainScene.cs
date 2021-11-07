using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMainScene : MonoBehaviour
{
    void onMouseDown()
    {
        transform.localScale = new Vector3(0.55f, 0.55f, 0.55f);
        SceneManagement.LoadScene("main");
    }

    void onMouseUp()
    {
        transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
    }
}
