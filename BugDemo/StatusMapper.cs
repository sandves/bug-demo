using System;

namespace BugDemo
{
    public static class StatusMapper
    {
        public static ExternalStatus MapFrom(InternalStatus status)
        {
            switch (status)
            {
                case InternalStatus.Unallocated:
                case InternalStatus.UnderConsideration:
                    return ExternalStatus.InProgress;
                case InternalStatus.Approved:
                case InternalStatus.Refused:
                    return ExternalStatus.Completed;
                default: throw new Exception("Unknown status");
            }
        }
    }
}