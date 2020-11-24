using System;

namespace masterpage
{
    internal class MasterPage : MasterPageItem
    {
        public string Title { get; set; }
        public Type TargetType { get; set; }
    }
}