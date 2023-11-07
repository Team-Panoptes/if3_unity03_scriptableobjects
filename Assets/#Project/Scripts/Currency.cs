using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node {
    public List<int> coins;
    public List<Node> children;

    public int[] coinValues = new int[] {50, 20, 10, 5, 2, 1};

    public void CreateChildren() {
        int coinIndex = 0;
        if (coins != null) {
            int smallestCoin = coins[coins.Count - 1];
            coinIndex = Array.IndexOf(coinValues, smallestCoin);
        }
        // Créer les children avec les coins plus petites ou égales à la plus petite de la liste
    }

    public int GetValue() {
        int total = 0;
        foreach (int c in coins) {
            total += c;
        }
        return total;
    }

}


public class Currency : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
