﻿namespace Web.API.Controllers;

public interface ISimpleLogger
{
    void Log(string message);
    void Log(string message, string messageType);
}