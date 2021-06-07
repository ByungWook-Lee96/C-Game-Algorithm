using System;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            const int WAIT_TICK = 1000 / 30; //  1/30인데 1이 밀리세컨드라서 1000
            const char CIRCLE = '\u25cf';

            int lastTick = 0;
            while (true)
            {
                #region 프레임 관리 //경과 시간을 알고 싶어서 사용한것
                int currentTick = System.Environment.TickCount; //단위가 밀리세컨드
                //만약에 경과한 시간이 1/30초보다 작다면
                if (currentTick - lastTick < WAIT_TICK)
                    continue;
                lastTick = currentTick;
                #endregion
                // 입력

                // 로직

                // 렌더링
                Console.SetCursorPosition(0, 0);
                
                for(int i = 0; i < 25; i++)
                {
                    for(int j = 0; j < 25; j++)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(CIRCLE);
                    }
                    Console.WriteLine();
                }
            }
            
            
        }
    }
}
