#region CopyRight
/**************************************************************
   Copyright (c) 2016 ShiPengFei. All rights reserved.
   CLR版本        :    4.0.30319.42000
   命名空间名称   :    Common
   文件名         :    VerifyCodeHelper
   创建时间       :    2016/8/19 16:39:14
   用户所在的域   :    SHIPENGFEI
   登录用户名     :    admin
   文件描述       :    
   版本           :    1.0.0
   历史           :    
   最后更新人     :   
   最后更新时间   :   
 **************************************************************/
#endregion CopyRight

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class VerifyCodeHelper
    {
        #region 属性
        /// <summary>
        /// 验证码长度
        /// </summary>
        public int CodeLength { get; set; }
        /// <summary>
        /// 验证码库
        /// </summary>
        public String CodeWareroom { get; private set; }
        /// <summary>
        /// 混淆线数量
        /// </summary>
        public int GarbleLineCount { get; private set; }
        /// <summary>
        /// 混淆线颜色
        /// </summary>
        public Color GarbleLineColor { get; set; }
        /// <summary>
        /// 混淆线大小
        /// </summary>
        public int GarbleLineSize { get; set; }
        /// <summary>
        /// 默认混淆库
        /// </summary>
        private String DefaultCodeWareroom = "ABCDEFGHIJKLMNPQRSTUVWXYZ0123456789";
        /// <summary>
        /// 验证码大小
        /// </summary>
        private int bitmapWith = 200, bitmapHeight = 60;
        /// <summary>
        /// 随机数
        /// </summary>
        private Random random = new Random();
        #endregion

        #region 构造器
        public VerifyCodeHelper()
        {
            Init();
        }

        public VerifyCodeHelper(int CodeLength)
        {
            Init();
            this.CodeLength = CodeLength;
        }
        #endregion

        private void Init()
        {
            CodeLength = 5;
            GarbleLineCount = 6;
            GarbleLineSize = 2;
            GarbleLineColor = Color.Black;
            CodeWareroom = DefaultCodeWareroom;
        }

        #region
        /// <summary>
        /// 设置验证码图片宽度
        /// </summary>
        /// <param name="bitmapWith"></param>
        public void SetBitmapWith(int bitmapWith)
        {
            this.bitmapWith = bitmapWith;
        }

        /// <summary>
        /// 设置验证码图片高度
        /// </summary>
        /// <param name="bitmapHeight"></param>
        public void SetBitmapHeight(int bitmapHeight)
        {
            this.bitmapHeight = bitmapHeight;
        }

        /// <summary>
        /// 添加验证码库
        /// </summary>
        public void AddCodeWareroom(String CodeWareroom)
        {
            foreach (var c in CodeWareroom)
            {
                if (this.CodeWareroom.IndexOf(c) < 0)
                {
                    this.CodeWareroom = this.CodeWareroom.Insert(this.CodeWareroom.Length, c.ToString());
                }
            }
        }

        /// <summary>
        /// 删除验证码库
        /// </summary>
        /// <param name="CodeWareroom"></param>
        public void RemoveCodeWareroom(String CodeWareroom)
        {
            foreach (var c in CodeWareroom)
            {
                RemoveCodeWareroom(c);
            }
        }

        /// <summary>
        /// 删除验证码库
        /// </summary>
        /// <param name="Code"></param>
        public void RemoveCodeWareroom(char Code)
        {
            if (this.CodeWareroom.IndexOf(Code) >= 0)
            {
                var list = this.CodeWareroom.ToList();
                list.Remove(Code);
                this.CodeWareroom = String.Concat(list);
            }
        }

        /// <summary>
        /// 设置混淆线数量
        /// </summary>
        public void SetGarbleLineCount(int GarbleLineCount)
        {
            this.GarbleLineCount = GarbleLineCount;
        }
        #endregion

        /// <summary>
        /// 产生验证码
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public Bitmap CreateVerifyCode(out string code)
        {
            bitmapWith = bitmapWith < CodeLength * 48 ? CodeLength * 45 : bitmapWith;
            //建立Bitmap对象，绘图
            Bitmap bitmap = new Bitmap(bitmapWith, bitmapHeight);
            Graphics graph = Graphics.FromImage(bitmap);
            graph.FillRectangle(new SolidBrush(Color.White), 0, 0, bitmapWith, bitmapHeight);
            Font font = new Font(FontFamily.GenericSerif, 48, FontStyle.Bold, GraphicsUnit.Pixel);
            
            code = CreatedRandomCode();
            int index = 0;
            foreach (var c in code)
            {
                graph.DrawString(c.ToString(), font, new SolidBrush(Color.Black), index++ * 38, random.Next(0, 15));
            }

            this.CreatedGarbleLine(graph);
            return bitmap;
        }

        /// <summary>
        /// 从CodeWareroom中产生长度为CodeLength的验证码
        /// </summary>
        /// <returns></returns>
        public String CreatedRandomCode()
        {
            var sb = new StringBuilder();
            //添加随机的CodeLength个字母
            for (int x = 0; x < CodeLength; x++)
            {
                string letter = CodeWareroom.Substring(random.Next(0, CodeWareroom.Length - 1), 1);
                sb.Append(letter);
            }
            return sb.ToString();
        }

        public void CreatedGarbleLine(Graphics graph)
        {
            //混淆背景
            Pen linePen = new Pen(new SolidBrush(GarbleLineColor), GarbleLineSize);
            for (int x = 0; x < GarbleLineCount; x++)
            {
                graph.DrawLine(linePen
                    , new Point(random.Next(0, bitmapWith - 1), random.Next(0, bitmapHeight - 1))
                    , new Point(random.Next(0, bitmapWith - 1), random.Next(0, bitmapHeight - 1)));
            }
        }
    }
}
