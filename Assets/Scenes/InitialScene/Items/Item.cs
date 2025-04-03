using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Item : MonoBehaviour
{

    public Sprite Sprite;

    public abstract void Activate();
}
