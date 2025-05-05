using UnityEngine;
using System;
public class GameManager : MonoBehaviour
{

    public event Action OnMainMenu;
    public event Action OnItemsMenu;
    public event Action OnARPosition;

    public static GameManager instance;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MainMenu();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MainMenu()
    {
        OnMainMenu?.Invoke();
        Debug.Log("Main menu activado");
    }

    public void ItemsMenu()
    {
        OnItemsMenu?.Invoke();
        Debug.Log("Items menu activado");
    }

    public void ARPosition()
    {
        OnARPosition?.Invoke();
        Debug.Log("AR Position activado");
    }

    public void CloseApp()
    {
        Application.Quit();
        Debug.Log("Aplicacion cerrada");

    }
}
