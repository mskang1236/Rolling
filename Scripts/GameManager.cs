using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    private GameObject sphere;
    private GameObject cube;
    private GameObject capsule;
    private GameObject cylinder;
    private GameObject rect;
    private bool sphereFall;
    private bool cubeFall;
    private bool capsuleFall;
    private bool cylinderFall;
    private bool rectFall;

    public bool gameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        sphere = GameObject.Find("Sphere");
        cube = GameObject.Find("Cube");
        capsule = GameObject.Find("Capsule");
        cylinder = GameObject.Find("Cylinder");
        rect = GameObject.Find("Rect");
        gameOver = false;

    }

    // Update is called once per frame
    void Update()
    {

        if (gameOver == false)
        {
            sphereFall = sphere.GetComponent<SphereRolling>().sphereFall;
            cubeFall = cube.GetComponent<CubeScript>().cubeFall;
            capsuleFall = capsule.GetComponent<CapsuleScript>().CapsuleFall;
            cylinderFall = cylinder.GetComponent<CylinderScript>().CylinderFall;
            rectFall = rect.GetComponent<RectScript>().RectFall;
        }

        if ((sphereFall == true) && (cubeFall == true) && (capsuleFall == true) && (cylinderFall == true) && (rectFall == true))
        {
            gameOver = true;
            SceneManager.LoadScene("GameOver");
        }

        //Print Time
        //Debug.Log(Time.time);
    }

    public void StartGame()
    {
        gameOver = false;
        SceneManager.LoadScene("Gameplay");
    }


}
