﻿using System;
using RepoLayer.MessengerInterfaces;

namespace AppLayer
{
    public class TextResponse : IResponse
    {
        public string Text { get; }

        public TextResponse(string responseText, ResponseStatus status)
        {
            if(responseText.Length == 0)
                throw new ArgumentException("Empty response text");
            Text = responseText;
            Status = status;
        }
        public ResponseStatus Status { get; set; }
    }
}
