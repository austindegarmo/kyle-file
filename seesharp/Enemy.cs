using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace TextRPG
{

    public class Enemy : Character {

        public override void TakeDamage(int amount)
        {
            base.TakeDamage(amount);
            Debug.Log("enemy took damage, this only happens to this enemy");
        }

        public override void Die()
        {
            Debug.Log("this character has died. thisn")
        }



    }
}