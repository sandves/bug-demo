using System;
using Xunit;

namespace BugDemo.UnitTests
{
    public class StatusMapperTests
    {
        [Theory]
        [InlineData(InternalStatus.Unallocated, ExternalStatus.InProgress)]
        public void Mapping_internal(InternalStatus internalStatus, ExternalStatus externalStatus)
        {
            var mappedStatus = StatusMapper.MapFrom(internalStatus);
            Assert.Equal(externalStatus, mappedStatus);
        }
    }
}
