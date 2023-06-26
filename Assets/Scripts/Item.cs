using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// 아이템 회전 효과 로직
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
