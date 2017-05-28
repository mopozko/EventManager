﻿using Telegram.Bot.Types.ReplyMarkups;

namespace TaskManager.UILayer
{
    public class BotData
    {
        public string Text { get; }
        public IReplyMarkup Markup { get; }

        public BotData(string text, IReplyMarkup markup = null)
        {
            Text = text;
            Markup = markup;
        }
    }
}