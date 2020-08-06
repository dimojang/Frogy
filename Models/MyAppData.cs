﻿using Frogy.Methods;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Frogy.Models
{
    /// <summary>
    /// 应用数据类
    /// </summary>
    class MyAppData
    {
        /// <summary>
        /// 所有时间线 key为日期(DateTime),value为MyDay
        /// </summary>
        public Dictionary<DateTime,MyDay> AllDays { get; set; } = new Dictionary<DateTime, MyDay>();

        /// <summary>
        /// 保存应用数据
        /// </summary>
        /// <param name="URL">文件路径</param>
        public void Save(string URL)
        {
            string Content = MyDataHelper.CoverObjectToJson(AllDays);
            MyDataHelper.WriteFile(URL, Content);
        }

        /// <summary>
        /// 读取应用数据
        /// </summary>
        /// <param name="URL">文件路径</param>
        public void Load(string URL)
        {
            string Json = MyDataHelper.ReadFile(URL);
            AllDays = MyDataHelper.CoverJsonToObject<Dictionary<DateTime, MyDay>>(Json);
        }
    }
}
