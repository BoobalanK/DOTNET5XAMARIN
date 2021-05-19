using System;

using SampleApp.Library.NET5;

namespace SampleApp.Common.Library
{
    public partial class CommonClass
    {
        public static string GetTheOutput()
        {
            return NET5Class.LibraryMethod();
        }
    }
}
