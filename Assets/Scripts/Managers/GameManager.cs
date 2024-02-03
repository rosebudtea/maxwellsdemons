using UnityEngine;

public class GameManager : MonoBehaviour
{
    enum GameState
    {
        Playing,
        Dialog,
        Menu
    }

    GameState state = GameState.Playing;
    public float interactRange = 0.5f;

    public DialogueManager dialogueManager;
    public MenuManager menuManager;

    // Start is called before the first frame update
    void Start()
    {
        state = GameState.Playing;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.E))
        {
            if (state == GameState.Dialog)
            {
                if (dialogueManager.CheckTextFinished())
                {
                    ResumeGame();
                }
            }
            else if (state == GameState.Menu)
            {
                if (menuManager.SelectMenuItem())
                {
                    ResumeGame();
                }
            }
            else if (state == GameState.Playing)
            {
                // Need to change this to the player's transform
                Collider[] colliders = Physics.OverlapSphere(GameObject.Find("Player").transform.position, interactRange);
                foreach (Collider collider in colliders)
                {
                    Debug.Log(collider);
                    if (collider.TryGetComponent(out DialogueTrigger npc))
                    {
                        state = GameState.Dialog;
                        PauseGame();
                        npc.TriggerDialogue();
                        break;
                    }
                    else if (collider.TryGetComponent(out BuildingTrigger building))
                    {
                        building.TriggerNewScene();
                        break;
                    }
                    else if (collider.TryGetComponent(out ItemTrigger item))
                    {
                        item.PickUpItem();
                        break;
                    }
                }
            }
        }
        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (state == GameState.Menu)
            {
                menuManager.CloseMenu();
                ResumeGame();
            }
            else if (state == GameState.Playing)
            {
                state = GameState.Menu;
                menuManager.menuState = MenuManager.MenuState.Pause;
                menuManager.OpenMenu();
                PauseGame();
            }
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            if (state == GameState.Menu)
            {
                if (menuManager.menuState != MenuManager.MenuState.Pause)
                {
                    Debug.Log("Back To Pause");
                    menuManager.BackToPauseMenu();
                }
            }
        }
    }

    void PauseGame()
    {
        FindObjectOfType<PlayerMovement>().enabled = false;
    }

    void ResumeGame()
    {
        state = GameState.Playing;
        FindObjectOfType<PlayerMovement>().enabled = true;
    }
}
