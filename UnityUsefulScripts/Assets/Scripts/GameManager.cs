using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum GameState
{
    WAIT,
    START,
    OVER,
}

public class GameManager : Singleton<GameManager>
{
    private GameState m_gameState = GameState.WAIT;
    public static event Action<GameState> OnGameStateChanged;

    private void UpdateGameState(GameState state)
    {
        if (state == m_gameState)
        {
            return;
        }
        m_gameState = state;
        switch (state)
        {
            case GameState.WAIT:
                break;
            case GameState.START:
                break;
            case GameState.OVER:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(state), state, null);
        }

        OnGameStateChanged?.Invoke(state);
    }
}
