﻿using System;

namespace Reddit.Exceptions
{
    public class RedditException : Exception
    {
        public RedditException(string message, Exception inner)
            : base(message, inner) { }

        public RedditException(string message)
            : base(message) { }

        public RedditException() { }
    }
}
