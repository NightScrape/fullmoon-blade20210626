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
        SceneManager.LoadScene("�����a��");
    }
    public void ReturnStart()
    {
        Invoke("ReturnTitle", 1.5f);
    }
    private void ReturnTitle()
    {
        SceneManager.LoadScene("���D");
    }
    public void EnterBattle()
    {
        Invoke("LoadBattle", 2);
    }
    private void LoadBattle()
    {
        SceneManager.LoadScene("�԰�����");
    }
    public void QuitGame()
    {
        Invoke("DelayQuitGame", 2);
    }
    private void DelayQuitGame()
    {
        Application.Quit(); 
        print("���}�C��");
    }
}
