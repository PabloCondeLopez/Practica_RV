using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.XR.Interaction.Toolkit;
public class ActivateFlashlight : MonoBehaviour
{
    void Start()
    {
        XRBaseInteractable interactable = GetComponent<XRBaseInteractable>();
        interactable.activated.AddListener(ActivateFlash);
    }
    void ActivateFlash(BaseInteractionEventArgs args)
    {
        if (args.interactorObject is XRBaseControllerInteractor interactor)
        {
            interactor.SendHapticImpulse(0.5f, 1);
        }
    }
}
