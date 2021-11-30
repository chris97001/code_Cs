using System;

namespace Week4_p1_template
{
    internal class Program
    {
        private static Random rnd = new Random();

        private static void DrawCard(int[] player, bool[] seen, ref bool hasAce)
        {
            int card = rnd.Next(0, 52);
            while (seen[card])
            {
                card = rnd.Next(0, 52);
            }

            seen[card] = true;
            for (int i = 0; i < player.Length; i++)
            {
                if (player[i] == -1)
                {
                    player[i] = card;
                    if (CardNumber(card) == 1)
                    {
                        hasAce = true;
                    }
                    return;
                }
            }
        }

        private static string CardSuit(int card)
        {
            switch (card / 13)
            {
                case 0:
                    return "Club";

                case 1:
                    return "Diamond";

                case 2:
                    return "Heart";

                case 3:
                    return "Spade";

                default:
                    return "";
            }
        }

        private static int CardNumber(int card)
        {
            int number = (card % 13) + 1;
            return number;
        }

        private static int NumberSum(int[] player, ref bool hasAce)
        {
            int sum = 0;
            for (int i = 0; i < player.Length; i++)
            {
                int card = CardNumber(player[i]) > 10 ? 10 : CardNumber(player[i]);
                if (player[i] != -1)
                {
                    sum += card;
                }
                else
                {
                    break;
                }
            }
            if (hasAce && sum <= 11)
            {
                sum += 10;
            }

            return sum;
        }

        private static void OutputCard(int[] player)
        {
            for (int i = 0; i < player.Length; i++)
            {
                if (player[i] != -1)
                {
                    Console.Write("{0} {1}, ", CardSuit(player[i]), CardNumber(player[i]));
                }
                else
                {
                    break;
                }
            }
        }

        private static void Main(string[] args)
        {
            bool[] seen = new bool[52];
            int[] player1hand = new int[15];
            int[] player2hand = new int[15];
            int player1money = 0;
            int player2money = 0;
            try
            {
                // 程式流程
                // 1. 輸入玩家1、玩家2初始金錢(需要格式檢查)
                //
                while (true)
                {
                    Console.Write("玩家1初始金錢: ");
                    player1money = int.Parse(Console.ReadLine());
                    if (player1money == 0)
                    {
                        Console.WriteLine("金錢不能為零，請重新輸入");
                    }
                    else
                    {
                        break;
                    }
                }
                while (true)
                {
                    Console.Write("玩家2初始金錢: ");
                    player2money = int.Parse(Console.ReadLine());
                    if (player2money == 0)
                    {
                        Console.WriteLine("金錢不能為零，請重新輸入");
                    }
                    else
                    {
                        break;
                    }
                }
                while (true)
                {
                    bool hasAce1 = false;
                    bool hasAce2 = false;
                    //initialize handcard
                    for (int i = 0; i < 15; i++)
                    {
                        player1hand[i] = -1;
                        player2hand[i] = -1;
                    }
                    for (int i = 0; i < 52; i++)
                    {
                        seen[i] = false;
                    }
                    // 2. 顯示玩家1初始手牌、點數、金錢並下注，需檢查下注金額不能為0、金錢不足與格式檢查
                    //    手牌花色：Spade, Heart, Diamond, Club
                    //    手牌點數：1~13
                    //    手牌顯示格式: "花色 點數"
                    //
                    DrawCard(player1hand, seen, ref hasAce1);
                    DrawCard(player1hand, seen, ref hasAce1);
                    int player1sum = NumberSum(player1hand, ref hasAce1);
                    Console.Write("玩家1手牌:");
                    OutputCard(player1hand);

                    Console.WriteLine("玩家1目前點數: {0}", NumberSum(player1hand, ref hasAce1));
                    Console.WriteLine("玩家1目前金錢: {0}", player1money);

                    int player1bet;
                    while (true)
                    {
                        Console.Write("請輸入下注金額: ");
                        player1bet = int.Parse(Console.ReadLine());
                        if (player1bet == 0)
                        {
                            Console.WriteLine("金錢不能為零，請重新輸入");
                        }
                        else if (player1money - player1bet < 0)
                        {
                            Console.WriteLine("金錢不足，請重新輸入!");
                        }
                        else
                        {
                            player1money -= player1bet;
                            break;
                        }
                    }
                    //    金錢不足：Console.WriteLine("金錢不足，請重新輸入!");、並重新輸入
                    //    下注金額0：Console.WriteLine("金錢不能為零，請重新輸入!");、並重新輸入
                    //
                    // 3. 顯示玩家2初始手牌、點數、金錢並下注，需檢查下注金額不能為0、金錢不足與格式檢查
                    //
                    DrawCard(player2hand, seen, ref hasAce2);
                    DrawCard(player2hand, seen, ref hasAce2);
                    int player2sum = NumberSum(player2hand, ref hasAce2);
                    Console.Write("玩家2手牌:");
                    OutputCard(player2hand);

                    Console.WriteLine("玩家2目前點數: {0}", NumberSum(player2hand, ref hasAce2));
                    Console.WriteLine("玩家2目前金錢: {0}", player2money);

                    int player2bet;
                    while (true)
                    {
                        Console.Write("請輸入下注金額: ");
                        player2bet = int.Parse(Console.ReadLine());
                        if (player2bet == 0)
                        {
                            Console.WriteLine("金錢不能為零，請重新輸入");
                        }
                        else if (player2money - player2bet < 0)
                        {
                            Console.WriteLine("金錢不足，請重新輸入!");
                        }
                        else
                        {
                            player2money -= player2bet;
                            break;
                        }
                    }
                    //    金錢不足：Console.WriteLine("金錢不足，請重新輸入!");、並重新輸入
                    //    下注金額0：Console.WriteLine("金錢不能為零，請重新輸入!");、並重新輸入
                    //
                    // 4. 兩位玩家依序行動(不斷抽牌或停止抽牌)
                    //    注意1：抽牌完要顯示玩家手牌與點數
                    //    注意2：選擇停止抽牌，需印出當前點數
                    //
                    int whoWin = 0;
                    while (true)
                    {
                        Console.WriteLine("玩家1行動(輸入1抽1張牌、輸入P停止抽牌):");
                        string operation;
                        operation = Console.ReadLine();
                        if (operation.Contains("1"))
                        {
                            DrawCard(player1hand, seen, ref hasAce1);
                            Console.WriteLine("玩家1手牌: ");
                            OutputCard(player1hand);
                            Console.WriteLine("玩家1目前點數: {0}", NumberSum(player1hand, ref hasAce1));
                            if (NumberSum(player1hand, ref hasAce1) > 21)
                            {
                                Console.WriteLine("玩家1爆了，玩家2獲勝");
                                whoWin = 2;
                                break;
                            }
                        }
                        else if (operation.Contains("P"))
                        {
                            Console.WriteLine("玩家1跳過，目前點數: " + NumberSum(player1hand, ref hasAce1));
                            break;
                        }
                    }
                    while (true)
                    {
                        if (whoWin == 2)
                        {
                            break;
                        }

                        Console.WriteLine("玩家2行動(輸入1抽1張牌、輸入P停止抽牌):");
                        string operation;
                        operation = Console.ReadLine();
                        if (operation.Contains("1"))
                        {
                            DrawCard(player2hand, seen, ref hasAce2);
                            Console.WriteLine("玩家2手牌: ");
                            OutputCard(player2hand);
                            Console.WriteLine("玩家2目前點數: {0}", NumberSum(player2hand, ref hasAce2));
                            if (NumberSum(player2hand, ref hasAce2) > 21)
                            {
                                Console.WriteLine("玩家2爆了，玩家1獲勝");
                                whoWin = 1;
                                break;
                            }
                        }
                        else if (operation.Contains("P"))
                        {
                            Console.WriteLine("玩家2跳過，目前點數: " + NumberSum(player2hand, ref hasAce2));
                            break;
                        }
                    }
                    Console.WriteLine();
                    if (whoWin == 0)
                    {
                        if (NumberSum(player1hand, ref hasAce1) > NumberSum(player2hand, ref hasAce2))
                        {
                            whoWin = 1;
                        }
                        else if (NumberSum(player1hand, ref hasAce1) < NumberSum(player2hand, ref hasAce2))
                        {
                            whoWin = 2;
                        }
                        else
                        {
                            whoWin = 3;
                        }
                    }
                    if (whoWin == 1)
                    {
                        Console.WriteLine("玩家1獲勝，獲得" + player2bet + "金錢");
                        player1money += player1bet+player2bet;
                    }
                    if (whoWin == 2)
                    {
                        Console.WriteLine("玩家2獲勝，獲得" + player1bet + "金錢");
                        player2money += player1bet+player2bet;
                    }
                    if (whoWin == 3)
                    {
                        Console.WriteLine("平手!拿回各自的錢");
                        player1money += player1bet;
                        player2money += player2bet;
                    }
                    // 5. 結果判定
                    //    case1 : 玩家1在抽牌時超過21點，直接判定玩家2獲勝(跳過玩家2行動)
                    //            Console.WriteLine("玩家1爆了，玩家2獲勝!");
                    //    case2 : 玩家2在抽牌時超過21點，直接判定玩家1獲勝
                    //            Console.WriteLine("玩家2爆了，玩家1獲勝!");
                    //    case3 : 若雙方都沒超過21點，比較點數大小並判斷勝敗平手
                    //
                    //    玩家1/2獲勝：Console.WriteLine("玩家1/2獲勝，獲得" + [玩家2/1下注金錢] + "金錢");
                    //    平手：Console.WriteLine("平手!拿回各自的錢");
                    //
                    if (player1money > 0 && player2money > 0)
                    {
                        Console.WriteLine("------------------------------");
                        continue;
                    }
                    else
                    {
                        break;
                    }
                    // 6. 如果雙方都還有錢就回到步驟2，否則結束程式
                    //
                    // 格式檢查錯誤：Console.WriteLine("請輸入正確格式");、並直接結束程式
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("請輸入正確格式");
                Console.ReadKey();
                return;
            }
            Console.ReadKey();
        }
    }
}