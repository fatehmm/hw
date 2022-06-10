using System;
namespace VotingApp
{
	public class Product
	{
		public Product()
		{
			
		}
		public string Name;
		public double Rating
        {
			get { return Rating; }

            set
            {
				double totalRating = 0;
                foreach (var rating in RatingList)
                {
					totalRating += rating;

                }
				Rating = totalRating / RatingList.Length;

			}
        }
		public double[] RatingList = new double[0];

		
	}

}

