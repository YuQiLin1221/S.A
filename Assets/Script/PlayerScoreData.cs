using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerScoreData", menuName = "GameData/PlayerScoreData")]
public class PlayerScoreData : ScriptableObject
{
    public int score; // Điểm số của người chơi
}
