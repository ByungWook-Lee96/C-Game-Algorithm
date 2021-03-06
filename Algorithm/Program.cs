using System;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            Player player = new Player();
            board.Initialize(25,player);
            player.Initialize(1, 1,board);


            Console.CursorVisible = false;

            const int WAIT_TICK = 1000 / 30; //  1/30인데 1이 밀리세컨드라서 1000
            

            int lastTick = 0;
            while (true)
            {
                #region 프레임 관리 //경과 시간을 알고 싶어서 사용한것
                int currentTick = Environment.TickCount & Int32.MaxValue; //단위가 밀리세컨드
                //만약에 경과한 시간이 1/30초보다 작다면
                if (currentTick - lastTick < WAIT_TICK)
                    continue;
                int deltaTick = currentTick - lastTick;
                lastTick = currentTick;
                #endregion

                // 입력

                // 로직
                player.Update(deltaTick);
                // 렌더링
                Console.SetCursorPosition(0, 0);
                board.Render();
                
               
            }
            
            
        }
    }
}
