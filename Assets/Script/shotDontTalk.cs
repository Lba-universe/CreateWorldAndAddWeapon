using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotDontTalk : MonoBehaviour

{

    [SerializeField] float rayLength = 100f;
    [SerializeField] float rayDuration = 1f;
    [SerializeField] Color rayColor = Color.white;
    [SerializeField] Camera camera = null;
    [SerializeField] private GameObject _muzzleFlash;
    [SerializeField] private GameObject BulletHole;
    public float gunForce = 30f;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            
           

            _muzzleFlash.SetActive(true);
            //position ray casted from
            Ray rayOrigin = camera.ViewportPointToRay(new Vector3(0.5f, 0.59f, 0));
            Debug.DrawRay(rayOrigin.origin, rayOrigin.direction * rayLength, rayColor, rayDuration);
            RaycastHit hitInfo;
            if (Physics.Raycast(rayOrigin, out hitInfo))
            {
                if (hitInfo.rigidbody != null)
                {
                    hitInfo.rigidbody.AddForce(-hitInfo.normal * gunForce);
                }
                Debug.Log("ray hits: " + hitInfo.transform.name);
                GameObject hitMarker = (GameObject)Instantiate(BulletHole, hitInfo.point, Quaternion.LookRotation(hitInfo.normal));
                DestroyImmediate(BulletHole,false);
            }
        }

    

        else
        {
            _muzzleFlash.SetActive(false);

        }

    }
}
