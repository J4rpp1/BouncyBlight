using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable, CreateAssetMenu(fileName = "New Skin", menuName = "Create New Skin")]
public class SSkinInfo : ScriptableObject
{

    public enum SkinIDs { Fz1, Fz2, Fz3, Fz4, Fz5, Fz6, Fz7, Fz8, Fz9, Fz10, Fz11, Fz12 }
    public SkinIDs skinID;

    public Sprite skinSprite;

    public int skinPrice;

}
