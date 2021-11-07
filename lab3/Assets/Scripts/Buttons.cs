using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    void onMouseDown()
    {
        transform.localScale = new Vector3(0.55f, 0.55f, 0.55f);
    }

    void onMouseUp()
    {
        transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
    }
}
