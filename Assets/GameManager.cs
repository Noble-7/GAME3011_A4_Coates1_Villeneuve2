using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //The game object that holds all pipes (empty game object)
    public GameObject PipesHolder;

    //An array of all pipe game objects
    public GameObject[] Pipes;

    //How many pipes do we have?
    [SerializeField]
    public int totalPipes = 0;

    //How many pipes are currently correctly oriented?
    [SerializeField]
    int correctedPipes = 0;

    void Start()
    {
        //The total amount of pipes is equal to however many children the pipes holder has
        totalPipes = PipesHolder.transform.childCount;

        //initialize the array
        Pipes = new GameObject[totalPipes];


        //For every pipe we have
        for(int i = 0; i < Pipes.Length; i++)
        {
            //Populate the array
            Pipes[i] = PipesHolder.transform.GetChild(i).gameObject;
        }
    }


    //Call this when a pipe is clicked into the correct orientation
    public void correctMove()
    {
        //Increment the amount of pipes correctly placed
        correctedPipes++;

        //Debug, let the player know
        Debug.Log("Correct Move!");

        //If the amount of pipes we have is the same as the amount of correct pipes, then
        if(correctedPipes == totalPipes)
        {
            //You win!
            Debug.Log("You win!");
        }
    }

    //Call this when a pipe is clicked into the wrong orientation
    public void wrongMove()
    {
        //Decrement the amount of pipes correctly placed
        correctedPipes--;
        //Not necessary but, for flair
        Debug.Log("That's not quite it");
    }
}