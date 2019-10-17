using UnityEngine;
using System.Collections;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class SaveManager : MonoBehaviour
{
    public static SaveManager saveM;

    public Manager manager;
    public DarwinManager dManager;
    public MoedaManager mManager;

    // Add new persistent variables here.
    public float tempo;

    void Awake()
    {
        if (saveM == null)
        {
            DontDestroyOnLoad(gameObject);
            saveM = this;
            Load();
            Debug.Log(Application.persistentDataPath);
        }
        else if (saveM != this)
        {
            Destroy(gameObject);
        }
    }

    public void Save()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/gameInfo.dat");

        PlayerData data = new PlayerData();

        // Add new persistent variables to be saved here.
        data.moedasPegas = manager.pegouMoeda;
        data.moedasDepositadasDarwin = dManager.moedasDepositadas;
        data.moedasDepositadasManager = manager.moedasDepositadas;
        data.quantidadeMoedaDepositada = manager.quantidadeMoedaDepositada;
        data.quantidadeMoedaUI = manager.quantidadeMoedaUI;

        bf.Serialize(file, data);
        file.Close();
    }

    public void Load()
    {
        if (File.Exists(Application.persistentDataPath + "/gameInfo.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/gameInfo.dat",
                                        FileMode.Open);
            PlayerData data = (PlayerData)bf.Deserialize(file);
            file.Close();

            // Add new persistent variables to be loaded here.
            manager.pegouMoeda = data.moedasPegas;
            dManager.moedasDepositadas = data.moedasDepositadasDarwin;
            manager.moedasDepositadas = data.moedasDepositadasManager;
            manager.quantidadeMoedaDepositada = data.quantidadeMoedaDepositada;
            manager.quantidadeMoedaUI = data.quantidadeMoedaUI;
        }
    }

    [Serializable]
    class PlayerData
    {
        // Add new variables for loading and saving here.
        public bool[] moedasPegas;
        public bool[] moedasDepositadasDarwin;
        public bool[] moedasDepositadasManager;
        public int quantidadeMoedaDepositada;
        public int quantidadeMoedaUI;
    }

    private void OnApplicationPause()
    {
        Save();
    }

    private void OnApplicationQuit()
    {
        Save();
    }
}