using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Enemy‚Ì‘Ì—Í—p•Ï”
    private int enemyHP;

    // Start is called before the first frame update
    void Start()
    {
        enemyHP = 3;
    }

    public void Damage()
    {
        // Enemy‚Ì‘Ì—Í‚ğ1Œ¸‚ç‚·
        enemyHP = enemyHP - 1;
    }

    // Update is called once per frame
    void Update()
    {
        // ‚à‚µ‘Ì—Í‚ª0ˆÈ‰º‚É‚È‚Á‚½‚ç
        if(enemyHP <= 0)
        {
            // ©•ª‚ÅÁ‚¦‚é
            Destroy(this.gameObject);
        }
    }
}
