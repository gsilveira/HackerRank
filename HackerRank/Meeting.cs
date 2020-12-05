using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank
{
    class Meeting
    {
        public int StartTime { get; set; }

        public int EndTime { get; set; }

        public Meeting(int startTime, int endTime)
        {
            // Number of 30 min blocks past 9:00 am
            StartTime = startTime;
            EndTime = endTime;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            if (ReferenceEquals(obj, this))
            {
                return true;
            }

            var meeting = (Meeting)obj;
            return StartTime == meeting.StartTime && EndTime == meeting.EndTime;
        }

        public override int GetHashCode()
        {
            var result = 17;
            result = result * 31 + StartTime;
            result = result * 31 + EndTime;
            return result;
        }

        public override string ToString()
        {
            return $"({StartTime}, {EndTime})";
        }

        public static List<Meeting> MergeRanges(List<Meeting> meetings)
        {
            // Make a copy so we don't destroy the input, and sort by start time
            var sortedMeetings = meetings.OrderBy(m => m.StartTime).ToList();//Select(m => new Meeting(m.StartTime, m.EndTime))


            // Initialize mergedMeetings with the earliest meeting
            var mergedMeetings = new List<Meeting> { sortedMeetings[0] };

            foreach (var currentMeeting in sortedMeetings)
            {
                var lastMergedMeeting = mergedMeetings.Last();

                if (currentMeeting.StartTime <= lastMergedMeeting.EndTime)
                {
                    // If the current meeting overlaps with the last merged meeting, use the
                    // later end time of the two
                    lastMergedMeeting.EndTime =
                        Math.Max(lastMergedMeeting.EndTime, currentMeeting.EndTime);
                }
                else
                {
                    // Add the current meeting since it doesn't overlap
                    mergedMeetings.Add(currentMeeting);
                }
            }

            return mergedMeetings;
        }
    }
}
