using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullscreenToggle : MonoBehaviour
{
    public void Change(){
        Screen.fullScreen = !Screen.fullScreen;
        print("Screen Mode Changed");
    }
}
