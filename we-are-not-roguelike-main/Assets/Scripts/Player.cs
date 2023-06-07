using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D enemy)
    {
        if (enemy.gameObject.tag == "Enemy")
            StartCoroutine(ToDamage());
    }

    void OnCollisionExit2D(Collision2D enemy)
    {
        if (enemy.gameObject.tag == "Enemy")
            StopAllCoroutines();
    }

    private IEnumerator ToDamage()
    {
        while ( HealthBar.hp > 0)
        {
            HealthBar.hp -= 1;
            yield return new WaitForSeconds(1.0f);
        }
    }
}
