using UnityEngine;
using UnityEngine.XR;

public class Recenter : MonoBehaviour
{
    void Start()
    {
        XRDevice.SetTrackingSpaceType(TrackingSpaceType.RoomScale);
    }
}