// <copyright file="Monkey.cs" company="Monkey Console App">
// Copyright (c) 2025 Monkey Console App. All rights reserved.
// </copyright>

using System;

namespace MonkeyConsoleApp
{
    /// <summary>
    /// 원숭이 정보를 나타내는 모델 클래스입니다.
    /// </summary>
    public class Monkey
    {
        /// <summary>
        /// 원숭이의 이름
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 원숭이의 서식지 위치
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// 원숭이의 개체수
        /// </summary>
        public int Population { get; set; }

        /// <summary>
        /// 원숭이의 간단한 설명
        /// </summary>
        public string Description { get; set; }
    }
}
