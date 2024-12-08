using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crownhart_LibraryCatalog
{
    public class WaitList
    {
        private Queue<string> waitList = new Queue<string>();

        public string AddToWaitList(string userName)
        {
            waitList.Enqueue(userName);
            return $"{userName} was added to the waitlist";
        }

        public string NotifyNextUser()
        {
            if (waitList.Count > 0)
            {
                var nextUser = waitList.Dequeue();
                return $"Notify: {nextUser} that book is available";
            }

            return "No users are on the waitlist";
        }

        public Queue<string> getwaitList()
        {
            return waitList;
        }
    }
}
