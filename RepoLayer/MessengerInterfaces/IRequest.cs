﻿using System.Collections.Generic;

namespace RepoLayer.MessengerInterfaces
{
    public interface IRequest
    {
        Entity Author { get; }
        string Command { get; }
    }
}
