// <copyright file="Program.cs" company="Monkey Console App">
// Copyright (c) 2025 Monkey Console App. All rights reserved.
// </copyright>

using System;

namespace MonkeyConsoleApp
{
    /// <summary>
    /// Monkey 콘솔 앱의 진입점입니다.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// 콘솔 앱 메인 함수. 메뉴를 표시하고 사용자 입력을 처리합니다.
        /// </summary>
        public static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("============================");
                Console.WriteLine("🐒 Monkey Console App 🐒");
                Console.WriteLine("============================");
                Console.WriteLine("1. 모든 원숭이 목록 보기");
                Console.WriteLine("2. 이름으로 원숭이 검색");
                Console.WriteLine("3. 무작위 원숭이 보기");
                Console.WriteLine("0. 종료");
                Console.Write("메뉴를 선택하세요: ");
                var input = Console.ReadLine();
                Console.WriteLine();
                try
                {
                    switch (input)
                    {
                        case "1":
                            PrintAllMonkeys();
                            break;
                        case "2":
                            PrintMonkeyByName();
                            break;
                        case "3":
                            PrintRandomMonkey();
                            break;
                        case "0":
                            Console.WriteLine("프로그램을 종료합니다.");
                            return;
                        default:
                            Console.WriteLine("잘못된 입력입니다. 다시 시도하세요.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"오류 발생: {ex.Message}");
                }
                Console.WriteLine("\n아무 키나 누르면 계속합니다...");
                Console.ReadKey();
            }
        }

        private static void PrintAllMonkeys()
        {
            var monkeys = MonkeyHelper.GetAll();
            foreach (var monkey in monkeys)
            {
                PrintMonkeyWithArt(monkey);
                Console.WriteLine("----------------------------");
            }
        }

        private static void PrintMonkeyByName()
        {
            Console.Write("검색할 원숭이 이름을 입력하세요: ");
            var name = Console.ReadLine();
            var monkey = MonkeyHelper.FindByName(name ?? string.Empty);
            if (monkey != null)
            {
                PrintMonkeyWithArt(monkey);
            }
            else
            {
                Console.WriteLine("해당 이름의 원숭이를 찾을 수 없습니다.");
            }
        }

        private static void PrintRandomMonkey()
        {
            var monkey = MonkeyHelper.GetRandom();
            PrintMonkeyWithArt(monkey);
        }

        private static void PrintMonkeyWithArt(Monkey monkey)
        {
            Console.WriteLine(GetMonkeyAsciiArt());
            Console.WriteLine($"이름: {monkey.Name}");
            Console.WriteLine($"서식지: {monkey.Location}");
            Console.WriteLine($"개체수: {monkey.Population:N0}");
            Console.WriteLine($"설명: {monkey.Description}");
        }

        private static string GetMonkeyAsciiArt()
        {
            return @"   w  c( ..)o   ( )
    \__("__    __)
        (   (   (
         " "  " "";
        }
    }
}
