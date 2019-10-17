using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMoeda : MonoBehaviour
{
    public float movSpeed = 100f;
    public bool pegouMoeda = false;
    public GameObject particulaPref;
    public Manager manager;

    void Awake()
    {
        this.gameObject.SetActive(false);       
    }

    void Update()
    {
        if (this.gameObject.name == "moeda1")
        {
            if (manager.pegouMoeda[0] == true)
            {
                Debug.Log("askudhgaskdjhags1");
                pegouMoeda = true;
                movSpeed = 1000f;
            }
        }
        else if (this.gameObject.name == "moeda2")
        {
            if (manager.pegouMoeda[1] == true)
            {
                Debug.Log("askudhgaskdjhags2");
                pegouMoeda = true;
                movSpeed = 1000f;
            }
        }
        else if (this.gameObject.name == "moeda3")
        {
            if (manager.pegouMoeda[2] == true)
            {
                Debug.Log("askudhgaskdjhags3");
                pegouMoeda = true;
                movSpeed = 1000f;
            }
        }
        else if (this.gameObject.name == "moeda4")
        {
            if (manager.pegouMoeda[3] == true)
            {
                Debug.Log("askudhgaskdjhags4");
                pegouMoeda = true;
                movSpeed = 1000f;
            }
        }
        else if (this.gameObject.name == "moeda5")
        {
            if (manager.pegouMoeda[4] == true)
            {
                Debug.Log("askudhgaskdjhags5");
                pegouMoeda = true;
                movSpeed = 1000f;
            }
        }

        transform.Rotate(new Vector3(1, 0, 0) * movSpeed * Time.deltaTime);

        if (Input.touchCount > 0 || Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (pegouMoeda == true )
            {
                //StopCoroutine("MostraTexto");
                //StartCoroutine("MostraTexto");
            }

            if (pegouMoeda == false)
            {
                StartCoroutine("RotateFaster");
                pegouMoeda = true;
                Instantiate(particulaPref, this.transform.position, Quaternion.identity);
                manager.quantidadeMoedaUI += 1;
                GameObject moeda = Instantiate(manager.moedaUI, manager.panelMoedaUI.transform.position, Quaternion.identity) as GameObject;
                moeda.transform.SetParent(manager.panelMoedaUI.transform);
            }
        }

        
    }

    IEnumerator RotateFaster()
    {
        while (movSpeed < 1000f)
        {
            movSpeed += 10f;
            yield return null;
        }
        yield return null;
    }
}
