using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class Manager : MonoBehaviour
{
    public bool[] pegouMoeda;
    public bool[] moedaAtiva;
    public bool[] moedasDepositadas;
    public DefaultTrackableEventHandler trackerDarwin;
    public DefaultTrackableEventHandler[] trackerMoeda;

    public GameObject parquimetro, pDinheiro, canvasShare, canvasNormal, panelMoedaUI, moedaUI;

    public int quantidadeMoedaUI = 0, quantidadeMoedaDepositada = 0;

    void Start()
    {
        if (quantidadeMoedaUI > 0)
        {
            for (int i = 0; i < quantidadeMoedaUI; i++)
            {
                GameObject moeda = Instantiate(moedaUI, panelMoedaUI.transform.position, Quaternion.identity) as GameObject;
                moeda.transform.SetParent(panelMoedaUI.transform);
            }
        }
    }

    void Update()
    {
        if (trackerDarwin.mostraDarwin == true)
        {
            parquimetro.GetComponent<Animator>().SetInteger("Moedas", quantidadeMoedaDepositada);
        }

        if (trackerMoeda[0].moedaAtiva[0] == true)
        {
            moedaAtiva[0] = true;
        }
        else
        {
            moedaAtiva[0] = false;
        }

        if (trackerMoeda[1].moedaAtiva[1] == true)
        {
            moedaAtiva[1] = true;
        }
        else
        {
            moedaAtiva[1] = false;
        }

        if (trackerMoeda[2].moedaAtiva[2] == true)
        {
            moedaAtiva[2] = true;
        }
        else
        {
            moedaAtiva[2] = false;
        }

        if (trackerMoeda[3].moedaAtiva[3] == true)
        {
            moedaAtiva[3] = true;
        }
        else
        {
            moedaAtiva[3] = false;
        }

        if (trackerMoeda[4].moedaAtiva[4] == true)
        {
            moedaAtiva[4] = true;
        }
        else
        {
            moedaAtiva[4] = false;
        }
    }

    IEnumerator Fim()
    {
        yield return new WaitForSeconds(2f);
        pDinheiro.SetActive(true);
        canvasShare.SetActive(true);
        canvasNormal.SetActive(false);
    }
}
