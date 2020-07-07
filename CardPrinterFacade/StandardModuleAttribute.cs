using System;
using System.ComponentModel;

namespace CardPrinterSDKv1
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    internal class StandardModuleAttribute : Attribute
    {

    }
}
