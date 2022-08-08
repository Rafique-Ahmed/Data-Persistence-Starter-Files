using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;
   
//Rafique
    public string Mname;
    public GameObject Inputfield;

    private void Awake()
    {
            // start of new code
    if (Instance != null)
    {
        Destroy(gameObject);
        return;
    }
    // end of new code

    Instance = this;
    DontDestroyOnLoad(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

        //Rafique
    public void StoreName(){
    Mname = Inputfield.GetComponent<Text>().text;
    SceneManager.LoadScene(1);
    }

}
