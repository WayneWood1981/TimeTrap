using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseBonusParticles : MonoBehaviour
{

    PlayersBonus playersBonus;

    public ParticleSystem PSRewind;
    public ParticleSystem PSPause;
    public ParticleSystem PSForward;

    public GameObject _player;
    // Start is called before the first frame update
    void Start()
    {
        
        
        PSRewind.Stop();
        PSPause.Stop();
        PSForward.Stop();
    }

    public void getPlayer(string player)
    {
        _player = GameObject.FindGameObjectWithTag(player);
        playersBonus = _player.GetComponent<PlayersBonus>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playersBonus != null)
        {
            if (playersBonus.hasRWBonus)
            {
                if (!PSRewind.isPlaying)
                {
                    PSRewind.Play();
                }


            }
            else
            {
                if (PSRewind.isPlaying)
                {
                    PSRewind.Stop();
                }

            }

            if (playersBonus.hasPPBonus)
            {
                if (!PSPause.isPlaying)
                {
                    PSPause.Play();
                }

            }
            else
            {
                if (PSPause.isPlaying)
                {
                    PSPause.Stop();
                }

            }

            if (playersBonus.hasFFBonus)
            {
                if (!PSForward.isPlaying)
                {
                    PSForward.Play();
                }

            }
            else
            {
                if (PSForward.isPlaying)
                {
                    PSForward.Stop();
                }

            }
        }
        
    }
}
