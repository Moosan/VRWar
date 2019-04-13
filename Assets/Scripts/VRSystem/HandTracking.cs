using UnityEngine;
using UnityEngine.XR;

public class HandTracking : MonoBehaviour
{
    public XRNode hand;
    void Update()
    {
        transform.localPosition = InputTracking.GetLocalPosition(hand);
        transform.localRotation = InputTracking.GetLocalRotation(hand);
    }
}