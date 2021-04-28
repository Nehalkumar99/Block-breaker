using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level : MonoBehaviour
{

    [SerializeField] int breakableBlocks;
    
   
    public void countBreakableBlocks()
    {
        breakableBlocks++;
    }
   public void countBrokenBlocks()
    {
        breakableBlocks--;
        if(breakableBlocks==0)
        {
            loadNextScene();
        }
    }
    private void loadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
}
