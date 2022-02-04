using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserStories.Models;

namespace UserStories.Services
{
    public class UserStoryService
    {
        private List<UserStory> userStories;

        public UserStoryService()
        {
            userStories = MockData.MockUserStories.GetUserStories();
        }

        public List<UserStory> GetUserStories()
        {
            return userStories;
        }

        public UserStory GetUserStory(int id)
        {
            foreach (UserStory userStory in userStories)
            {
                if (userStory.Id == id) return userStory;
            }
            return null;
        }

        public UserStory DeleteUserStory(int userStoryId)
        {
            UserStory userStoryToBeDeleted = null;
            foreach (UserStory userStory in userStories)
            {
                if (userStory.Id == userStoryId)
                {
                    userStoryToBeDeleted = userStory;
                    break;
                }
            }

            if (userStoryToBeDeleted != null)
            {
                userStories.Remove(userStoryToBeDeleted);
            }

            return userStoryToBeDeleted;
        }
    }
}
