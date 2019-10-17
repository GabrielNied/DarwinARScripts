using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarwinManager : MonoBehaviour
{
    public bool[] moedasDepositadas;

    public Manager manager;

    public Animator animDarwin, moedaParquimetro;

    public GameObject pMoeda, pPropulsor, panelMoedaUI;

    void Start()
    {
        animDarwin = GetComponent<Animator>();

    }

    void Update()
    {
        //Arrumar depositar uma moeda por vez, salvar as infos, dps de tudo, apagar tudo e ativar logo darwin, playstore;
        if (manager.trackerDarwin.mostraDarwin)
        {
            if (manager.pegouMoeda[0])
            {
                if (moedasDepositadas[0] == false)
                {
                    if (Input.GetMouseButtonDown(0) || Input.touchCount > 0)
                    {
                        moedasDepositadas[0] = true;
                        manager.quantidadeMoedaUI -= 1;
                    }
                }
            }
            if (manager.pegouMoeda[1] == true)
            {
                if (moedasDepositadas[1] == false)
                {
                    if (Input.GetMouseButtonDown(0) || Input.touchCount > 0)
                    {
                        moedasDepositadas[1] = true;
                        manager.quantidadeMoedaUI -= 1;
                    }
                }
            }
            if (manager.pegouMoeda[2] == true)
            {
                if (moedasDepositadas[2] == false)
                {
                    if (Input.GetMouseButtonDown(0) || Input.touchCount > 0)
                    {
                        moedasDepositadas[2] = true;
                        manager.quantidadeMoedaUI -= 1;
                    }
                }
            }
            if (manager.pegouMoeda[3] == true)
            {
                if (moedasDepositadas[3] == false)
                {
                    if (Input.GetMouseButtonDown(0) || Input.touchCount > 0)
                    {
                        moedasDepositadas[3] = true;
                        manager.quantidadeMoedaUI -= 1;
                    }
                }
            }
            if (manager.pegouMoeda[4] == true)
            {
                if (moedasDepositadas[4] == false)
                {
                    if (Input.GetMouseButtonDown(0) || Input.touchCount > 0)
                    {
                        moedasDepositadas[4] = true;
                        manager.quantidadeMoedaUI -= 1;
                    }
                }
            }

            if (moedasDepositadas[0] && !manager.moedasDepositadas[0])
            {
                if (Input.GetMouseButtonDown(0) || Input.touchCount > 0)
                {
                    manager.quantidadeMoedaDepositada += 1;
                    moedasDepositadas[0] = false;
                    if (panelMoedaUI.transform.childCount > 0)
                    {
                        Destroy(panelMoedaUI.transform.GetChild(0).gameObject);
                    }
                    moedaParquimetro.SetTrigger("Chamou");
                    StartCoroutine("ChamaParticula");
                    manager.moedasDepositadas[0] = true;
                }
            }
            else if (moedasDepositadas[1] && !manager.moedasDepositadas[1])
            {
                if (Input.GetMouseButtonDown(0) || Input.touchCount > 0)
                {
                    manager.quantidadeMoedaDepositada += 1;
                    moedasDepositadas[1] = false;
                    if (panelMoedaUI.transform.childCount > 0)
                    {
                        Destroy(panelMoedaUI.transform.GetChild(0).gameObject);
                    }
                    moedaParquimetro.SetTrigger("Chamou");
                    StartCoroutine("ChamaParticula");
                    manager.moedasDepositadas[1] = true;
                }
            }
            else if (moedasDepositadas[2] && !manager.moedasDepositadas[2])
            {
                if (Input.GetMouseButtonDown(0) || Input.touchCount > 0)
                {
                    manager.quantidadeMoedaDepositada += 1;
                    moedasDepositadas[2] = false;
                    if (panelMoedaUI.transform.childCount > 0)
                    {
                        Destroy(panelMoedaUI.transform.GetChild(0).gameObject);
                    }
                    moedaParquimetro.SetTrigger("Chamou");
                    StartCoroutine("ChamaParticula");
                    manager.moedasDepositadas[2] = true;
                }
            }
            else if (moedasDepositadas[3] && !manager.moedasDepositadas[3])
            {
                if (Input.GetMouseButtonDown(0) || Input.touchCount > 0)
                {
                    manager.quantidadeMoedaDepositada += 1;
                    moedasDepositadas[3] = false;
                    if (panelMoedaUI.transform.childCount > 0)
                    {
                        Destroy(panelMoedaUI.transform.GetChild(0).gameObject);
                    }
                    moedaParquimetro.SetTrigger("Chamou");
                    StartCoroutine("ChamaParticula");
                    manager.moedasDepositadas[3] = true;
                }
            }
            else if (moedasDepositadas[4] && !manager.moedasDepositadas[4])
            {
                if (Input.GetMouseButtonDown(0) || Input.touchCount > 0)
                {
                    manager.quantidadeMoedaDepositada += 1;
                    moedasDepositadas[4] = false;
                    if (panelMoedaUI.transform.childCount > 0)
                    {
                        Destroy(panelMoedaUI.transform.GetChild(0).gameObject);
                    }
                    moedaParquimetro.SetTrigger("Chamou");
                    StartCoroutine("ChamaParticula");
                    manager.moedasDepositadas[4] = true;
                }
            }

            if (manager.quantidadeMoedaDepositada > 4)
            {
                if (Input.GetMouseButtonDown(0) || Input.touchCount > 0)
                {
                    animDarwin.SetTrigger("Fim");
                    pPropulsor.SetActive(true);
                    manager.StartCoroutine("Fim");
                }
            }
        }
    }

    IEnumerator ChamaParticula()
    {
        pMoeda.SetActive(true);
        yield return new WaitForSeconds(1f);
        pMoeda.SetActive(false);
    }
}
