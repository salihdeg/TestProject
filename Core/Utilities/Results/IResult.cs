using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //For the base voids
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}
