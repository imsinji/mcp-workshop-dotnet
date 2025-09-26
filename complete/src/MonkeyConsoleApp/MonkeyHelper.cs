// <copyright file="MonkeyHelper.cs" company="Monkey Console App">
// Copyright (c) 2025 Monkey Console App. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;

namespace MonkeyConsoleApp
{
    /// <summary>
    /// Monkey 데이터 관리 및 검색을 위한 정적 헬퍼 클래스입니다.
    /// </summary>
    public static class MonkeyHelper
    {
        private static readonly List<Monkey> monkeys = new()
        {
            new Monkey { Name = "Golden Snub-nosed Monkey", Location = "중국", Population = 8000, Description = "밝은 금색 털을 가진 희귀 원숭이." },
            new Monkey { Name = "Proboscis Monkey", Location = "보르네오", Population = 7000, Description = "큰 코가 특징인 보르네오 섬 원숭이." },
            new Monkey { Name = "Japanese Macaque", Location = "일본", Population = 114000, Description = "눈 내리는 온천에 들어가는 일본 원숭이." },
            new Monkey { Name = "Mandrill", Location = "중앙 아프리카", Population = 4000, Description = "화려한 얼굴과 엉덩이 색을 가진 대형 원숭이." },
            new Monkey { Name = "Howler Monkey", Location = "남아메리카", Population = 100000, Description = "큰 소리로 울부짖는 남미 원숭이." }
        };

        /// <summary>
        /// 모든 Monkey 리스트를 반환합니다.
        /// </summary>
        public static IReadOnlyList<Monkey> GetAll() => monkeys;

        /// <summary>
        /// 이름으로 Monkey를 검색합니다.
        /// </summary>
        /// <param name="name">검색할 원숭이 이름</param>
        /// <returns>Monkey 객체 또는 null</returns>
        public static Monkey? FindByName(string name) =>
            monkeys.FirstOrDefault(m => m.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

        /// <summary>
        /// 무작위 Monkey를 반환합니다.
        /// </summary>
        public static Monkey GetRandom()
        {
            var rand = new Random();
            return monkeys[rand.Next(monkeys.Count)];
        }
    }
}
