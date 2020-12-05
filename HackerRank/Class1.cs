using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HackerRank
{
    public class Solution
    {
        // METHOD SIGNATURE BEGINS, THIS METHOD IS REQUIRED
        public List<string> topNCompetitors(int numCompetitors,
                                            int topNCompetitors,
                                            List<string> competitors,
                                            int numReviews, List<string> reviews)
        {
            List<CompetReviews> reviewsPerComp = new List<CompetReviews>();

            //return number of reviews per competitor
            for (int i = 0; i < numCompetitors; i++)
            {
                string nameCompetitor = competitors[i];
                int count = 0;

                for (int review = 0; review < numReviews; review++)
                {
                    bool hasReview = reviews.Contains(nameCompetitor);

                    if (hasReview)
                    {
                        count++;
                    }
                }

                CompetReviews obj = new CompetReviews();
                obj.competitorName = nameCompetitor;
                obj.countReview = count;
                reviewsPerComp.Add(obj);
            }

            //order reviews
            reviewsPerComp = reviewsPerComp.OrderByDescending(x => x.countReview).ToList();

            //return names
            List<string> topCompetitorsName = new List<string>();
            for (int top = 0; top < topNCompetitors; top++)
            {
                topCompetitorsName.Add(reviewsPerComp[top].competitorName);
            }

            return topCompetitorsName;

        }

        public struct CompetReviews
        {
            public string competitorName;
            public int countReview;
        }
        // METHOD SIGNATURE ENDS
    }
}
