using UnityEngine;
using Valve.VR;
public abstract class HandAttachment : MonoBehaviour
{
    [SerializeField]//なんのボタンを受け取るかをインスペクターで決めれる
    private SteamVR_Action_Boolean actionBool;
    public void OnTouch()
    {
        
    }
}
