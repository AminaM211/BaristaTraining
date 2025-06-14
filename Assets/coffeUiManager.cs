using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoffeeUIManager : MonoBehaviour
{
    [Header("Panels")]
    [SerializeField] private CanvasGroup coffeeSelectionPanel;
    [SerializeField] private CanvasGroup instructionsPanel;

    [Header("Instruction Texts")]
    [SerializeField] private TMP_Text instructionTitle;
    [SerializeField] private TMP_Text instructionDescription;

    // Called when a coffee button is clicked
    public void SelectCoffee(string coffeeType)
    {
        TogglePanel(coffeeSelectionPanel, false);
        TogglePanel(instructionsPanel, true);

        switch (coffeeType.ToLower())
        {
            case "latte_cow":
                instructionTitle.text = "Cow latte";
                instructionDescription.text = "1. Grab a cup on the counter\n2. Grab the white milk jug\n3. Pour the milk into the cup\n4. Brew espresso using the coffee machine\n5. Serve!";
                break;

            case "latte_almond":
                instructionTitle.text = "Almond latte";
                instructionDescription.text = "1. Grab a cup on the counter\n2. Grab the green milk jug\n3. Pour the milk into the cup\n4. Brew espresso using the coffee machine\n5. Serve!";
                break;

            case "black coffee":
                instructionTitle.text = "Black Coffee";
                instructionDescription.text = "1. Grab a cup on the counter\n2. Place it under the coffee machine\n3. Press the button to brew black coffee\n4. Serve!";
                break;

            case "espresso":
                instructionTitle.text = "Espresso";
                instructionDescription.text = "1. Grab a cup on the counter\n2. Place it under the coffee machine\n3. Press the button to brew espresso\n4. Serve!";
                break;

            default:
                instructionTitle.text = "Unknown Selection";
                instructionDescription.text = "Please pick a valid coffee type.";
                break;
        }
    }

    // Called when the back button is clicked
    public void GoBackToSelection()
    {
        TogglePanel(instructionsPanel, false);
        TogglePanel(coffeeSelectionPanel, true);
    }

    // Reusable method to enable/disable panels
    private void TogglePanel(CanvasGroup panel, bool show)
    {
        panel.alpha = show ? 1 : 0;
        panel.blocksRaycasts = show;
        panel.interactable = show;
    }
}
