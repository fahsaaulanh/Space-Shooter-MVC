using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class AllDataPlayer
{
    public DataPlayer[] DataPlayer;

    public AllDataPlayer(DataPlayer[] data)
    {
        DataPlayer = data;
    }
}

[Serializable]
public class DataPlayer
{
    public string _name;
    public int _score;

    public DataPlayer(string _name, int _score)
    {
        this._name = _name;
        this._score = _score;
    }
}

