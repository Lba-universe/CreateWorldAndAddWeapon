﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hideMouse : MonoBehaviour
{
  
        void Start()
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (!Cursor.visible)
                {
                    Cursor.visible = true;
                    Cursor.lockState = CursorLockMode.None;
                }
                else
                {
                    Cursor.visible = false;
                    Cursor.lockState = CursorLockMode.Locked;
                }
            }
        }
    
}
