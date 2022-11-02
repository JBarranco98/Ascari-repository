using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuentaMonedas : MonoBehaviour
{
    public int currentCoins;

    public void GetCoins(int coinAmount)
    {
        currentCoins += coinAmount;
        Debug.Log("He recogido una moneda, ya tengo " + currentCoins + " monedas.");
    }
}