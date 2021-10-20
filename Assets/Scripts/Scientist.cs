using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scientist : MonoBehaviour
{
    [SerializeField] private List<Sprite> Sprites;
    public SpriteRenderer spriteRenderer;
    public int selected;

    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        selected = Random.Range(0, Sprites.Count);                  //valitsee random spriten
        spriteRenderer.sprite = Sprites[selected];
        
    }

   
    
}