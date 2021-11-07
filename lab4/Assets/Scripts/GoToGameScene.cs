using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToGameScene : MonoBehaviour
{
    void onMouseDown()
    {
        transform.localScale = new Vector3(0.55f, 0.55f, 0.55f);
        SceneManagement.LoadScene("game");
    }

    void onMouseUp()
    {
        transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
    }
}
