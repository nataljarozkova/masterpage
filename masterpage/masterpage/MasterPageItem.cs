using System;

namespace masterpage
{
    internal class MasterPageItem
    {
        public string Title { get; internal set; }
        public string IconSource { get; internal set; }
        public Type TargetType { get; internal set; }
    }
}