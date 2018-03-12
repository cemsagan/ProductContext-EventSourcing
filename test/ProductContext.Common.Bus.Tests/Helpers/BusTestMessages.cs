﻿using ProductContext.Framework;

namespace ProductContext.Common.Bus.Tests.Helpers
{
    public class TestMessage : Message
    {
    }

    public class TestMessage2 : Message
    {
    }

    public class TestMessage3 : Message
    {
    }

    public class ParentTestMessage : Message
    {
    }

    public class ChildTestMessage : ParentTestMessage
    {
    }

    public class GrandChildTestMessage : ChildTestMessage
    {
    }

    public class TestMessageWithId : Message
    {
        public int Id;

        public TestMessageWithId(int id)
        {
            Id = id;
        }
    }
}