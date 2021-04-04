using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour
{

    private static string[] wordList = {    "ugliest", "cave","respect", "useful", "winter", "soggy", "advice", "children", "jewel", "therapeutic", "umbrella", "blushing", 
                                        "wonder","pump", "creature", "achiever", "size", "lazy", "haircut", "effect", "furry", "mellow", "numerous", "nimble", "humorous", "whip", "war", 
                                        "sort", "awful", "marble", "jumpy", "plucky", "mountain", "melted", "frighten", "profit", "creator", "digestion", "need", "snake", "selective", 
                                        "thundering", "puffy", "troubled", "cough", "wave", "pine" ,"wry", "kitty", "laborer"};

    public static string GetRandomWord()
    {
        int randomIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList(randomIndex);
        
        return randomWord;
    }
}
