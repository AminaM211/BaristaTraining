using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SocketTagValidator_Second : XRSocketInteractor
{
    public string allowedTag = "cupontray"; // Pas deze tag aan in de Inspector

    // Deze methode controleert of het object de juiste tag heeft en of het selecteerbaar is
    public override bool CanSelect(IXRSelectInteractable interactable)
    {
        // Controleer of het object de juiste tag heeft
        if (interactable.transform.CompareTag(allowedTag))
        {
            return base.CanSelect(interactable); // Laat het object in de socket plaatsen
        }
        return false; // Anders niet
    }
}
