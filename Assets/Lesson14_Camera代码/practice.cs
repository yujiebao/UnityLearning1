using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class practice : MonoBehaviour
{
    [SerializeField] private GameObject obj;
    [SerializeField] private Transform cube;
    // Start is called before the first frame update
    void Start()
    {
        print(Camera.main.WorldToScreenPoint(cube.position));
    
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
       {
        Vector3 mouseposition = Input.mousePosition;
        mouseposition.z = 5;
        Vector3 position = Camera.main.ScreenToWorldPoint(mouseposition);
        Instantiate(obj,position,obj.transform.rotation);

       }
    }
}
