﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LV5_rppoon
{
    abstract class Note
    {
        private string message;
        private ITheme theme;
        public Note(string message, ITheme theme)
        {
            this.message = message;
            this.theme = theme;
        }
        public string Message { get { return this.message; } }
        public ITheme Theme { set { this.theme = value; } }
        protected void ChangeColor()
        {
            this.theme.SetBackgroundColor();
            this.theme.SetFontColor();
        }
        protected string GetFramedMessage()
        {
            int width = this.message.Length;
            return this.theme.GetHeader(width) + "\n" +
           message + "\n" + this.theme.GetFooter(width);
        }
        public abstract void Show();
    }
}
