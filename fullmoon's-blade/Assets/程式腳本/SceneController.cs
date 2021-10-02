using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void LoadGameScene()
    {
        Invoke("DelayLoadGameScene", 2);
    }
    private void DelayLoadGameScene()
    {
        SceneManager.LoadScene("探索地圖");
    }
    public void ReturnStart()
    {
        Invoke("ReturnTitle", 1.5f);
    }
    private void ReturnTitle()
    {
        SceneManager.LoadScene("標題");
    }
    public void EnterBattle()
    {
        Invoke("LoadBattle", 2);
    }
    private void LoadBattle()
    {
        SceneManager.LoadScene("戰鬥介面");
    }
    public void QuitGame()
    {
        Invoke("DelayQuitGame", 2);
    }
    private void DelayQuitGame()
    {
        Application.Quit(); 
        print("離開遊戲");
    }
}
