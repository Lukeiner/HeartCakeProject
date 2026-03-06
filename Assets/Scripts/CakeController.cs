using UnityEngine;

public class CakeControlle : MonoBehaviour
{
    [Header("References")]
    public Renderer cakeRenderer;
    public GameObject Cake;

    [Header("Flavor Materials")]
    public Material chocolate;
    public Material vainilla;
    public Material redVelvet;

    private Material actual;

    [Header("Toppings")]
    public GameObject creamBase;
    public GameObject creamTopBorder;
    public GameObject creamTopBorder_1;


    private void Start()
    {
        actual = Cake.GetComponent<Renderer>().material;
    }

    public void SetFlavor(Material newFlavor)
    {
        cakeRenderer.material = newFlavor;
    }

    public void SetChocolate()
    {
        SetFlavor(chocolate);
        actual = chocolate;
        changeDecor(actual);
    }

    public void SetVainilla()
    {
        SetFlavor(vainilla);
        actual = vainilla;
        changeDecor(actual);
    }

    public void SetRedVelvet()
    {
        SetFlavor(redVelvet);
        actual = redVelvet;
        changeDecor(actual);
    }

    public void ToggleTopping(GameObject topping)
    {
        topping.SetActive(!topping.activeSelf);
    }

    public void ToggleCreamBase()
    {
        ToggleTopping(creamBase);
        creamBase.GetComponent<Renderer>().material = Cake.GetComponent<Renderer>().material;
    }

    public void ToggleTopBorder()
    {
        ToggleTopping(creamTopBorder);
        creamTopBorder.GetComponent<Renderer>().material = actual;
        ToggleTopping(creamTopBorder_1);
        creamTopBorder_1.GetComponent<Renderer>().material = actual;
    }

    private void changeDecor (Material mat)
    {
        creamBase.GetComponent<Renderer>().material = actual;
        creamTopBorder.GetComponent<Renderer>().material = actual;
        creamTopBorder_1.GetComponent<Renderer>().material = actual;
    }
}
