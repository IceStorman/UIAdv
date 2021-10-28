using UnityEngine;
using UnityEngine.UI;

public class WeaponsMechanics : MonoBehaviour
{
    [SerializeField] private Text combatLog;
    [SerializeField] private Text playerHPText;
    [SerializeField] private Text enemyHPText;

    [SerializeField] private int playerHP = 100;
    [SerializeField] private int enemyHP = 100;

    private bool isPlayerMove = true;
    private bool isGameEnd = false;

    private void Update()
    {
        if(playerHP <= 0)
        {
            combatLog.text = "You have been killed";
            isGameEnd = true;
        }
        
        if(enemyHP <= 0)
        {
            combatLog.text = "You have killed enemy";
            isGameEnd = true;
        }

        if (!isPlayerMove && !isGameEnd)
        {
            int rnd = Random.Range(0, 4);

            if(rnd == 1)
            {
                int rnd2 = Random.Range(0, 100);

                if (rnd2 <= 21)
                {
                    playerHP -= 100;
                    playerHPText.text = playerHP.ToString();
                }

                isPlayerMove = true;
            }
            else if(rnd == 2)
            {
                int rnd2 = Random.Range(0, 100);

                if (rnd2 <= 10)
                {
                    playerHP -= 100;
                    playerHPText.text = playerHP.ToString();
                }
                else if (rnd2 >= 80)
                {
                    playerHP -= 55;
                    playerHPText.text = playerHP.ToString();
                }
                else
                {
                    playerHP -= 15;
                    playerHPText.text = playerHP.ToString();
                }
                isPlayerMove = true;
            }
            else if(rnd == 3)
            {
                int rnd2 = Random.Range(0, 100);

                if (rnd2 <= 6)
                {
                    playerHP -= 100;
                    playerHPText.text = playerHP.ToString();
                }
                else if (rnd2 >= 85)
                {
                    playerHP -= 85;
                    playerHPText.text = playerHP.ToString();
                }
                else
                {
                    playerHP -= 35;
                    playerHPText.text = playerHP.ToString();
                }
                isPlayerMove = true;
            }
        }
    }

    public void KnifeMechanic()
    {
        if (isPlayerMove && !isGameEnd)
        {
            int rnd = Random.Range(0, 100);

            if (rnd <= 21)
            {
                enemyHP -= 100;
                enemyHPText.text = enemyHP.ToString();
            }

            isPlayerMove = false;
        }
    }

    public void PistolMechanic()
    {
        if (isPlayerMove && !isGameEnd)
        {
            int rnd = Random.Range(0, 100);

            if (rnd <= 10)
            {
                enemyHP -= 100;
                enemyHPText.text = enemyHP.ToString();
            }
            else if (rnd >= 80)
            {
                enemyHP -= 55;
                enemyHPText.text = enemyHP.ToString();
            }
            else
            {
                enemyHP -= 15;
                enemyHPText.text = enemyHP.ToString();
            }
            isPlayerMove = false;
        }
    }

    public void SniperWeaponMechanic()
    {
        if (isPlayerMove && !isGameEnd)
        {
            int rnd = Random.Range(0, 100);

            if (rnd <= 6)
            {
                enemyHP -= 100;
                enemyHPText.text = enemyHP.ToString();
            }
            else if (rnd >= 85)
            {
                enemyHP -= 85;
                enemyHPText.text = enemyHP.ToString();
            }
            else
            {
                enemyHP -= 35;
                enemyHPText.text = enemyHP.ToString();
            }
            isPlayerMove = false;
        }
    }
}
