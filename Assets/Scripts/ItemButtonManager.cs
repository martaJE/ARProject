using System;
using UnityEngine;
using UnityEngine.UI;

public class ItemButtonManager : MonoBehaviour
{
    private string itemName;
    private string itemDescription;
    private Sprite itemImage;
    private GameObject item3DModel;

    private ARInteractionManager interactionManager;

    public string ItemName 
    { 
        set
        {
            itemName = value;
        }
    }
    public string ItemDescription
    {
        set => itemDescription = value;
    }
    public Sprite ItemImage
    {
        set => itemImage = value;
    }
    public GameObject Item3DModel
    {
        set => item3DModel = value;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.GetChild(0).GetComponent<Text>().text = itemName;
        transform.GetChild(1).GetComponent<RawImage>().texture = itemImage.texture;
        transform.GetChild(2).GetComponent<Text>().text = itemDescription;

        var button = GetComponent<Button>();
        button.onClick.AddListener(GameManager.instance.ARPosition);
        button.onClick.AddListener(Create3DModel);

        interactionManager = FindObjectOfType<ARInteractionManager>();
        
    }

    private void Create3DModel()
    {
        interactionManager.Item3DModel = Instantiate(item3DModel);
       // Instantiate(item3DModel);

    }

}
