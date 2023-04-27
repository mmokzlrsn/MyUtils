 using UnityEngine;
using TMPro;
using UnityEngine.UI; 

public abstract class IShopButton: MonoBehaviour
{
    //start does not work in this abstract class so dont use it
    //instead call the method inside of the inherited class using base.FunctionName();
    public int Level;
    public int Price;
    public int BasePrice = 50;
    public float Amount;
    

    public TextMeshProUGUI levelText;
    public TextMeshProUGUI priceText;
    //public TextMeshProUGUI amountText;

    public virtual void Buy()
    {
        SetInteractability();
    }

    public abstract void SetValues(); //use inside of the child class
     

    public virtual void AddOnClickEvents()
    {
        if(TryGetComponent(out Button button))
        {
            button.onClick.AddListener(Buy);
        }
    }

    public virtual void ShowTexts() //you can call this with base.ShowTexts();
    {
        levelText.text = "Level "+(Level+1).ToString();
        priceText.text = Price.ToString();
    }

    public abstract void SetStartData();

    public virtual void SetInteractability()
    {
        GetComponentInParent<UpgradeManager>().SetInteractabilityOfButtons();
        //if(Price > Player.Instance.Money)
        //    GetComponent<Button>().interactable = false;
        //else
        //    GetComponent<Button>().interactable = true;
    }
}
