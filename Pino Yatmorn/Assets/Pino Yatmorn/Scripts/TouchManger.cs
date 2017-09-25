using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchManger : MonoBehaviour
{
    public static bool guiTouch = false;
    
    public void TouchInput()
    {        
            if (GetComponent<GUITexture>().HitTest(Input.GetTouch(0).position))
            {
                guiTouch = true;
                switch (Input.GetTouch(0).phase)
                {
                    case TouchPhase.Began:
                        guiTouch = true;
                        SendMessage("OnFirstTouchBegan");
                        SendMessage("OnFirstTouch");
                        break;
                    case TouchPhase.Moved:
                        guiTouch = true;
                        SendMessage("OnFirstTouchMoved");
                        SendMessage("OnFirstTouch");
                        break;  
                    case TouchPhase.Stationary:
                        guiTouch = true;
                        SendMessage("OnFirstTouchStationary");
                        SendMessage("OnFirstTouch");
                        break;
                    case TouchPhase.Ended:
                        SendMessage("OnFirstTouchEnded");
                        guiTouch = false;
                        break;
                }
            }
            if (GetComponent<GUITexture>().HitTest(Input.GetTouch(1).position))
            {
                
                switch (Input.GetTouch(1).phase)
                {
                    case TouchPhase.Began:
                        SendMessage("OnSecondTouchBegan");
                        SendMessage("OnSecondTouch");
                        break;
                    case TouchPhase.Moved:
                        SendMessage("OnSecondTouchMoved");
                        SendMessage("OnSecondTouch");
                        break;
                    case TouchPhase.Stationary:
                        SendMessage("OnSecondTouchStationary");
                        SendMessage("OnSecondTouch");
                        break;
                    case TouchPhase.Ended:
                        SendMessage("OnSecondTouchEnded");
                        guiTouch = false;
                        break;
                }
            }
        }
    }



