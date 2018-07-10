using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TextRPG
{
    public class Raccoon : Enemy
    {
        // Use this for initialization
        void Start()
        {
            Energy = 20;
            Attack = 2;
            Defence = 1;
            Gold = 10;
            Inventory.Add("Bandit Mask");
        }       
    }
}