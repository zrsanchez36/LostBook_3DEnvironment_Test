using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class UiHandler : MonoBehaviour
{
    public TextMeshProUGUI bookText;
    public int books = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bookText.text = " "+ books;
        if(books == 3)
        {
            SceneManager.LoadScene("GameEND");
        }
    }

}
