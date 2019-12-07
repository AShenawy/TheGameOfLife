using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_ManagerScript : MonoBehaviour
{

    public void DisableBoolAnimator(Animator anim)
	{
        anim.SetBool ("IsDisplayed", false);
        //anim.transform.gameObject.SetActive(false);
    }

    public void EnableBoolAnimator(Animator anim)
    {
        anim.transform.gameObject.SetActive(true);
        anim.SetBool ("IsDisplayed", true);
    }

    public void NavigateTo(int scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void ExitGame()
    {
        Application.Quit ();
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
    }

    public void UnPauseGame()
    {
        Time.timeScale = 1;
    }
}
