
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace test
{

    public class login : MonoBehaviour
    {


        public Dropdown dropdown;
        public static int value = 0;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void navigate()
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Roll-a-ball");
        }

        public void navigate_cube()
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Roll-a-ball-cube");
        }

        public void navigate_decide()
        {
            // Debug.Log(dropdown.value);

            value = dropdown.value;
            if (value == 0)
                UnityEngine.SceneManagement.SceneManager.LoadScene("Roll-a-ball");
            else
                UnityEngine.SceneManagement.SceneManager.LoadScene("Roll-a-ball-cube");
        }
    }
}
