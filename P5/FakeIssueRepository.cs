using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5
{
    public class FakeIssueRepository : IIssueRepository
    {
        public const string NO_ERROR = "";
        public const string EMPTY_TITLE_ERROR = "A Title is required.";
        public const string EMPTY_DISCOVERY_DATETIME_ERROR = "Must select a Discovery Date/Time.";
        public const string FUTURE_DISCOVERY_DATETIME_ERROR = "Issues can't be from the future.";
        public const string EMPTY_DISCOVERER_ERROR = "A Discoverer is required.";


        public const string DUPLICATE_TITLE_ERROR = "A unique Title required";

        private static List<Issue> _Issues = new List<Issue>();

        public int GetId()
        {
            return GetNextId();
        }

        public string Add(Issue issue)
        {
            if (IsDuplicate(issue.Title))
            {
                return DUPLICATE_TITLE_ERROR;
            }
            else
            {
                string msg = ValidateIssue(issue);
                if (msg.Equals(""))
                {
                    issue.Id = GetNextId();
                    _Issues.Add(issue);
                }
                return msg;
            }
        }
        public List<Issue> GetAll(int ProjectId)
        {
            List<Issue> newList = _Issues.ToList();
            int num = newList.RemoveAll(x => x.ProjectId != ProjectId);
            Console.WriteLine(num);
            return newList;
        }

        public bool Remove(Issue issue)
        {
            return _Issues.Remove(issue);
        }
        public string Modify(Issue issue)
        {
            if (IsDuplicate(issue.Title))
            {
                return DUPLICATE_TITLE_ERROR;
            }
            else
            {
                string msg = ValidateIssue(issue);
                if (msg.Equals(""))
                {
                    int index = _Issues.FindIndex(x => x.Id == issue.Id);
                    if (index != -1)
                    {
                        _Issues[index] = issue;
                        return msg;
                    }
                    else
                    {
                        return "This Issue Id doesn't exist yet.";
                    }
                }
                else
                {
                    return msg;
                }
            }
        }
        public int GetTotalNumberOfIssues(int ProjectId)
        {

            return GetAll(ProjectId).Count();
        }
        public List<string> GetIssuesByMonth(int ProjectId)
        {
            List<string> months = new List<string>();
            List<int> counts = new List<int>();

            List<string> list = new List<string>();

            List<Issue> all = GetAll(ProjectId);
            foreach (Issue x in all)
            {
                string newString;
                if (x.DiscoveryDate.Month < 10)
                {

                    newString = x.DiscoveryDate.Year.ToString() + " - 0" + x.DiscoveryDate.Month.ToString();
                }
                else
                {

                    newString = x.DiscoveryDate.Year.ToString() + " - " + x.DiscoveryDate.Month.ToString();
                }


                if (!months.Exists(y => y.Equals(newString)))
                {
                    months.Add(newString);
                    counts.Add(0);
                }

                ++counts[months.IndexOf(newString)];
            }

            foreach (string y in months)
            {
                list.Add(y + ": " + counts[months.IndexOf(y)]);
            }

            list.Sort();

            return list;
        }
        public List<string> GetIssuesByDiscoverer(int ProjectId)
        {
            List<string> discoverers = new List<string>();
            List<int> counts = new List<int>();

            List<string> list = new List<string>();

            List<Issue> all = GetAll(ProjectId);
            foreach (Issue x in all)
            {
                // Fill a list with all months used
                string newString = x.Discoverer;

                if (!discoverers.Exists(y => y.Equals(newString)))
                {
                    discoverers.Add(newString);
                    counts.Add(0);
                }

                ++counts[discoverers.IndexOf(newString)];
            }

            foreach (string y in discoverers)
            {
                list.Add(y + ": " + counts[discoverers.IndexOf(y)]);
            }

            list.Sort();

            return list;
        }
        public Issue GetIssueById(int Id)
        {
            List<Issue> newList = new List<Issue>(_Issues);
            return newList.Find(x => x.Id == Id);
        }

        private string ValidateIssue(Issue issue)
        {
            if (issue.Title.Equals(""))
            {
                return EMPTY_TITLE_ERROR;
            }
            else if (issue.DiscoveryDate.Equals(DateTime.MinValue))
            {
                return EMPTY_DISCOVERY_DATETIME_ERROR;
            }
            else if (DateTime.Compare(issue.DiscoveryDate, DateTime.Now) > 0)
            {
                return FUTURE_DISCOVERY_DATETIME_ERROR;
            }
            else if (issue.Discoverer.Equals(""))
            {
                return EMPTY_DISCOVERER_ERROR;
            }
            else
            {
                return NO_ERROR;
            }
        }
        private bool IsDuplicate(string title)
        {

            return false;
        }

        private int GetNextId()
        {
            int currentMaxId = 0;

            List<Issue> testList = new List<Issue>(_Issues);

            foreach (Issue x in testList)
            {
                if (currentMaxId < x.Id)
                {
                    currentMaxId = x.Id;
                }
            }

            return ++currentMaxId;
        }
    }
}
