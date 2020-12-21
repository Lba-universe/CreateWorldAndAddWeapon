using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindGun : MonoBehaviour
{
    private GameObject myGun;
    private GameObject temp;
    // Start is called before the first frame update
    void Start()
    {
        myGun = gameObject.transform.Find("pistol").gameObject;
        
    }

    // Update is called once per frame
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Gun2" || other.tag == "Gun1")
        {
            
            temp = other.gameObject;
            Transform transform2 = temp.transform;
            if (Input.GetKeyDown(KeyCode.E))
            {

                Debug.Log("LooL");
                Debug.Log(temp.name);
                Debug.Log(myGun.name);
                temp.transform.position = myGun.transform.position;
                temp.transform.rotation = transform.rotation;
                temp.transform.parent = transform;
                myGun.transform.parent = null;
                myGun = temp;
                
                

            }
        }
    }
}
