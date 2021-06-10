﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class Player
    {
        public int PosY { get; private set; }
        public int PosX { get; private set; } // 외부에서 수정은 불가
        Random _random = new Random();
        Board _board;

        public void Initialize(int posY, int posX,int destY,int destX, Board board) // 초기좌표는 외부에서 수정가능
        {
            PosY = posY;
            PosX = posX;

            _board = board;
        }

        const int MOVE_TICK = 100; // 0.1초로 사용
        int _sumTick = 0;
        public void Update(int deltaTick) // 1/30초라서 시간차이를 받아야함// 이전시간과 현재시간 차이
        {
            _sumTick += deltaTick;
            if(_sumTick >= MOVE_TICK) // 0.1초가 지나면 로직 실행
            {
                _sumTick = 0;

                // 여기에다가 0.1초마다 실행될 로직을 넣어준다.
                int randValue = _random.Next(0, 5);
                switch (randValue)
                {
                    case 0: // 상
                        if (PosY - 1 >= 0 && _board.Tile[PosY - 1, PosX] == Board.TileType.Empty)
                            PosY = PosY - 1;
                        break;
                    case 1: // 하
                        if (PosY + 1 < _board.Size && _board.Tile[PosY + 1, PosX] == Board.TileType.Empty)
                            PosY = PosY + 1;
                        break;
                    case 3: // 좌
                        if (PosX - 1 >= 0 && _board.Tile[PosY, PosX - 1] == Board.TileType.Empty)
                            PosX = PosX - 1;
                        break;
                    case 4: // 우
                        if (PosX + 1 < _board.Size && _board.Tile[PosY, PosX + 1] == Board.TileType.Empty)
                            PosX = PosX + 1;
                        break;
                }
            }
        }
    }
}