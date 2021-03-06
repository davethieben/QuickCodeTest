using System;
using Xunit;

namespace QuickCodeTest
{

    //Please fill in the implementation of the service defined below. This service is to keep track
    //of ids to return if they have been seen before. No 3rd party packages can be used and the method
    //must be thread safe to call.

    //create the implementation as efficiently as possible in both locking, memory usage, and cpu usage

    public interface IDuplicateCheckService
    {

        //checks the given id and returns if it is the first time we have seen it
        //IT IS CRITICAL that duplicates are not allowed through this system but false
        //positives can be tolerated at a maximum error rate of less than 1%
        bool IsThisTheFirstTimeWeHaveSeen(int id);

    }

    public class HighlyOptimizedThreadSafeDuplicateCheckService : IDuplicateCheckService
    {

        [Fact]
        public void IsThisTheFirstTimeWeHaveSeenTest()
        {
            throw new NotImplementedException();
        }

        public bool IsThisTheFirstTimeWeHaveSeen(int id)
        {
            if (id < 0)
            {
                throw new ArgumentOutOfRangeException("id");
            }

            throw new NotImplementedException();
        }
    }
}
