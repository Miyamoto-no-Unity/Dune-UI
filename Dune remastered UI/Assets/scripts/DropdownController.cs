using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropdownController : MonoBehaviour
{
    public GameObject dropObjectOne;
    public GameObject dropObjectTwo;  
    public Dropdown dropMenu; 




    public void RefreshDropDown()
    {
        if (dropMenu.value == 0)
         dropObjectOne.SetActive(true);
        else dropObjectTwo.SetActive(true);


    }





    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
