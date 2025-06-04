using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI txtMoney;

    // Start is called before the first frame update
    void Start()
    {
        txtMoney.text = "$0";
    }

    public void UpdateMoneyText(string moneyAmount)
    {
        txtMoney.text = "$" + moneyAmount;
    }

}
