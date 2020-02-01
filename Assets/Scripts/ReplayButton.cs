using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class ReplayButton : MonoBehaviour
{

   //public GameObject definedButton;
   //public UnityEvent OnClick = new UnityEvent();

    // Use this for initialization
    void OnMouseOver()
    {
        if(Input.GetMouseButtonUp(0))
        {
            SceneManager.LoadScene(0);
        }
    }
}
 /*   // Update is called once per frame
    void Update()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit Hit;

        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out Hit) && Hit.collider.gameObject == gameObject)
            {
                Debug.Log("Button Clicked");
                OnClick.Invoke();
            }
        }
    }
} */