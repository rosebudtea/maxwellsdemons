using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public enum MenuState
    {
        Pause,
        Party,
        Inventory,
        Option
    }

    public bool gameIsPaused = false;
    public MenuState menuState = MenuState.Pause;

    public GameObject pauseMenuUI;
    public GameObject partyMenuUI;
    public GameObject inventoryMenuUI;
    public GameObject optionMenuUI;

    List<TextMeshProUGUI> menuItemList;

    int selectedItem = 0;

    // Update is called once per frame
    void Update()
    {
        if (gameIsPaused)
        {
            ScrollMenu();
        }
    }

    void GetMenuItems(GameObject UI)
    {
        menuItemList = UI.GetComponentsInChildren<TextMeshProUGUI>().ToList();
    }

    void ScrollMenu()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow) && selectedItem < menuItemList.Count - 1)
        {
            ++selectedItem;
            UpdateItemSelection();
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow) && selectedItem > 0)
        {
            --selectedItem;
            UpdateItemSelection();
        }
    }

    void UpdateItemSelection()
    {
        for (int i = 0; i < menuItemList.Count; i++)
        {
            if (i == selectedItem)
            {
                menuItemList[i].color = Color.blue;
            }
            else
            {
                menuItemList[i].color = Color.black;
            }
        }
    }

    public bool SelectMenuItem()
    {
        switch (menuState)
        {
            case MenuState.Pause:
                return SelectFromPause();
            case MenuState.Party:
                return SelectFromParty();
            case MenuState.Inventory:
                return SelectFromInventory();
            case MenuState.Option:
                return SelectFromOption();
            default:
                Debug.Log("Invalid Menu State");
                break;
        }
        return true;
    }

    bool SelectFromPause()
    {
        switch (selectedItem)
        {
            case 0: // party
                CloseMenu();
                menuState = MenuState.Party;
                OpenMenu();
                return false;
            case 1: // bag
                CloseMenu();
                menuState = MenuState.Inventory;
                OpenMenu();
                return false;
            case 2: // save
                Debug.Log("Saving...");
                CloseMenu();
                return true;
            case 3: // load
                Debug.Log("Loading...");
                CloseMenu();
                return true;
            case 4: // options
                CloseMenu();
                menuState = MenuState.Option;
                OpenMenu();
                return false;
            case 5: // menu
                CloseMenu();
                SceneManager.LoadScene(0);
                return true;
            case 6: // quit
                CloseMenu();
                Application.Quit();
                return true;
            default:
                Debug.Log("Menu Default");
                CloseMenu();
                return true;
            }
    }

    bool SelectFromParty()
    {
        Debug.Log("Party!");
        return false;
    }

    bool SelectFromInventory()
    {
        Debug.Log("Inventory Selection");
        return false;
    }

    bool SelectFromOption()
    {
        Debug.Log("You have Options");
        return false;
    }

    public void BackToPauseMenu()
    {
        CloseMenu();
        menuState = MenuState.Pause;
        OpenMenu();
    }

    public void OpenMenu()
    {
        gameIsPaused = true;
        Debug.Log("Open Menu: " + menuState);
        switch (menuState)
        {
            case MenuState.Pause:
                pauseMenuUI.SetActive(true);
                selectedItem = 0;
                GetMenuItems(pauseMenuUI);
                break;
            case MenuState.Party:
                partyMenuUI.SetActive(true);
                break;
            case MenuState.Inventory:
                inventoryMenuUI.SetActive(true);
                selectedItem = 0;
                //GetMenuItems(inventoryMenuUI);
                break;
            case MenuState.Option:
                optionMenuUI.SetActive(true);
                selectedItem = 0;
                //GetMenuItems(pauseMenuUI);
                break;
            default:
                Debug.Log("Invalid Menu State");
                break;
        }

        Debug.Log("Menu Items: " + menuItemList.Count);
        UpdateItemSelection();
    }

    public void CloseMenu()
    {
        gameIsPaused = false;

        switch (menuState)
        {
            case MenuState.Pause:
                pauseMenuUI.SetActive(false);
                break;
            case MenuState.Party:
                partyMenuUI.SetActive(false);
                break;
            case MenuState.Inventory:
                inventoryMenuUI.SetActive(false);
                break;
            case MenuState.Option:
                optionMenuUI.SetActive(false);
                break;
            default:
                Debug.Log("Invalid Menu State");
                break;
        }

    }

/*    void Pause()
    {
        Debug.Log("Pause");
        pauseMenuUI.SetActive(true);
        FindObjectOfType<PlayerMovement>().enabled = false;
        FindObjectOfType<PlayerInteract>().enabled = false;
        Time.timeScale = 0f;
        gameIsPaused = true;
    }

    public void Resume()
    {
        Debug.Log("Resume");
        pauseMenuUI.SetActive(false);
        FindObjectOfType<PlayerMovement>().enabled = true;
        FindObjectOfType<PlayerInteract>().enabled = true;
        Time.timeScale = 1f;
        gameIsPaused = false;
    }*/
}
