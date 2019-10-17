using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoedaManager : MonoBehaviour
{
    public GameObject[] moedas;
    public GameObject text;

    public Manager manager;

    void Start()
    {

    }

    void Update()
    {
        if (manager.moedaAtiva[0])
        {
            moedas[0].SetActive(true);
            if (moedas[0].GetComponent<RotateMoeda>().pegouMoeda)
            {
                if (manager.pegouMoeda[0] == false)
                {
                    manager.pegouMoeda[0] = true;
                }
            }
        }
        else
        {
            moedas[0].SetActive(false);
        }

        if (manager.moedaAtiva[1])
        {
            moedas[1].SetActive(true);
            Debug.Log("asdasdas");
            if (moedas[1].GetComponent<RotateMoeda>().pegouMoeda)
            {
                if (manager.pegouMoeda[1] == false)
                {
                    manager.pegouMoeda[1] = true;

                }
            }
        }
        else
        {
            moedas[1].SetActive(false);
        }

        if (manager.moedaAtiva[2])
        {
            moedas[2].SetActive(true);
            if (moedas[2].GetComponent<RotateMoeda>().pegouMoeda)
            {
                if (manager.pegouMoeda[2] == false)
                {
                    manager.pegouMoeda[2] = true;
                }
            }
        }
        else
        {
            moedas[2].SetActive(false);
        }

        if (manager.moedaAtiva[3])
        {
            moedas[3].SetActive(true);
            if (moedas[3].GetComponent<RotateMoeda>().pegouMoeda)
            {
                if (manager.pegouMoeda[3] == false)
                {
                    manager.pegouMoeda[3] = true;
                }
            }
        }
        else
        {
            moedas[3].SetActive(false);
        }

        if (manager.moedaAtiva[4])
        {
            moedas[4].SetActive(true);
            if (moedas[4].GetComponent<RotateMoeda>().pegouMoeda)
            {
                if (manager.pegouMoeda[4] == false)
                {
                    manager.pegouMoeda[4] = true;
                }
            }
        }
        else
        {
            moedas[4].SetActive(false);
        }
    }


    IEnumerator MostraTexto()
    {
        text.SetActive(true);
        yield return new WaitForSeconds(2f);

        text.SetActive(false);
    }
}

