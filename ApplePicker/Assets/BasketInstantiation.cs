using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketInstantiation : MonoBehaviour
{
    [Header("Instcribed")]
    public GameObject basketPrefab;
    public int numBaskets = 3;
    public float basketBottom = -14f;
    public float basketSpaceing = 2f;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numBaskets; i++)
        {
            GameObject tBasketGO = Instantiate<GameObject>(basketPrefab);
            Vector3 pos = Vector3.zero;
            pos.y = basketBottom + (basketSpaceing * i);
            tBasketGO.transform.position = pos;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}