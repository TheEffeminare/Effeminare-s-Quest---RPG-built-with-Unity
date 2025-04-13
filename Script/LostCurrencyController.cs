// Anwesh Kumar Sahoo
// Written with Love Light and Rainbows
// Student ID 123103755

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LostCurrencyController : MonoBehaviour
{
    public int currency;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Player>() != null)
        {
            Debug.Log("currency picked up");
            PlayerManager.instance.currency += currency;
            Destroy(this.gameObject);
        }
    }
}
