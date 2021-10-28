using UnityEngine;
using UnityEngine.UI;

public class WeaponsMechanics : MonoBehaviour
{
    [SerializeField] private GameObject playAgainButton;

    [SerializeField] private Text combatLog;
    [SerializeField] private Text playerHPText;
    [SerializeField] private Text enemyHPText;

    [SerializeField] private GameObject knife;
    [SerializeField] private GameObject pistol;
    [SerializeField] private GameObject sniperWeapon;

    [SerializeField] private int playerHP = 100;
    [SerializeField] private int enemyHP = 100;

    private bool isPlayerMove = true;
    private bool isGameEnd = false;
    private bool isPlayerKnife = false;
    private bool isPlayerPistol = false;
    private bool isPlayerSniperWeapon = false;
    private bool isEnemyKnife = false;
    private bool isEnemyPistol = false;
    private bool isEnemySniperWeapon = false;

    private void Update()
    {
        if (!isGameEnd)
        {
            playAgainButton.SetActive(false);
        }
        else if (isGameEnd)
        {
            playAgainButton.SetActive(true);
        }

        if(playerHP <= 0)
        {
            combatLog.text = "You have been killed";
            isGameEnd = true;
            if (isEnemyKnife)
            {
                AllImagesOff();
                knife.SetActive(true);
            }
            else if (isEnemyPistol)
            {
                AllImagesOff();
                pistol.SetActive(true);
            }
            else if (isEnemySniperWeapon)
            {
                AllImagesOff();
                sniperWeapon.SetActive(true);
            }
        }
        
        if(enemyHP <= 0)
        {
            combatLog.text = "You have killed enemy";
            isGameEnd = true;
            if (isPlayerKnife)
            {
                AllImagesOff();
                knife.SetActive(true);
            }
            else if (isPlayerPistol)
            {
                AllImagesOff();
                pistol.SetActive(true);
            }
            else if (isPlayerSniperWeapon)
            {
                AllImagesOff();
                sniperWeapon.SetActive(true);
            }
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

                AllWeaponsFalse();
                isEnemyKnife = true;
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

                AllWeaponsFalse();
                isEnemyPistol = true;
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

                AllWeaponsFalse();
                isEnemySniperWeapon = true;
                isPlayerMove = true;
            }
        }
    }

    public void PlayAgain()
    {
        playerHP = 100;
        playerHPText.text = playerHP.ToString();
        enemyHP = 100;
        enemyHPText.text = enemyHP.ToString();
        isGameEnd = false;
        isPlayerMove = true;
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

            AllWeaponsFalse();
            isPlayerKnife = true;
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

            AllWeaponsFalse();
            isPlayerPistol = true;
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

            AllWeaponsFalse();
            isPlayerSniperWeapon = true;
            isPlayerMove = false;
        }
    }

    private void AllWeaponsFalse()
    {
        isPlayerKnife = false;
        isPlayerPistol = false;
        isPlayerSniperWeapon = false;
        isEnemyKnife = false;
        isEnemyPistol = false;
        isEnemySniperWeapon = false;
    }

    private void AllImagesOff()
    {
        knife.SetActive(false);
        pistol.SetActive(false);
        sniperWeapon.SetActive(false);
    }
}
