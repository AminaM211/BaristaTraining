using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SocketTagValidator : XRSocketInteractor
{
    public string allowedTag = "filterOnMachine";

    public override bool CanSelect(IXRSelectInteractable interactable)
    {
        return interactable.transform.CompareTag(allowedTag) && base.CanSelect(interactable);
    }
}
