using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public void HandleUpdate()
    {
        /*if (Input.GetKeyDown(KeyCode.E))
        {
            switch (selectedItem)
            {
                case 0: // party
                    LoadParty();
                    break;
                case 1: // bag
                    LoadInventory();
                    break;
                case 2: // save
                    Save();
                    break;
                case 3: // load
                    LoadLastSave();
                    break;
                case 4: // options
                    LoadOptions();
                    break;
                case 5: // menu
                    LoadMenu();
                    break;
                case 6: // quit
                    QuitGame();
                    break;
                default:
                    Debug.Log("Menu Default");
                    break;
            }
        }*/
    }

    public void LoadParty()
    {
        Debug.Log("Load Party");
    }

    public void Save()
    {
        Debug.Log("Save Game");
    }

    public void LoadLastSave()
    {
        Debug.Log("Load Last Save");
    }

    public void LoadOptions()
    {
        Debug.Log("Load Options Menu");
    }

    public void LoadMenu()
    {
        Debug.Log("Load Menu");
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }
}
