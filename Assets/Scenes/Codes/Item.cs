using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="New Item", menuName="Item/Make New Item")]

public class Item : ScriptableObject
{
    public string id;
    public Sprite icon;
    public GameObject prefab;



}
