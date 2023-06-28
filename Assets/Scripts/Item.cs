using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Item effect 
public class Item : MonoBehaviour
{
    public enum Type { Ammo, Coin, Grenade, Heart, Weapon };
    public Type type;
    public int value;

    void Update()
    {
        transform.Rotate(Vector3.up * 15 * Time.deltaTime);
    }
}
