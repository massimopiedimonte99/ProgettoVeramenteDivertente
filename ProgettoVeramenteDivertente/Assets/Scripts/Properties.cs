using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Properties : MonoBehaviour
{
    private bool targetable = true;

    public void setTargeatable(bool cond)
    {
        targetable = cond;
    }

    public bool getTargeatable()
    {
        return targetable;
    }
}
