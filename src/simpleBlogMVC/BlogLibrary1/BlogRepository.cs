using System;
using System.Collections.Generic;
using System.Text;

namespace nb.BlogLibrary1
{
    public class BlogRepository
    {
        private static List<Blog> _blogList = new List<Blog>();
        private static int _nextNum = 0;

        public void Add(Blog newBlog)
        {
            newBlog.Id = _nextNum++;
            _blogList.Add(newBlog);
        }

        public void Delete(int id)
        {
            Blog removeBlog = GetBlogById(id);
            _blogList.Remove(removeBlog);

        }

        public void Edit(Blog updatedBlog)
        {
            Blog origBlog = GetBlogById(updatedBlog.Id);
            origBlog.BlogText = updatedBlog.BlogText;
            origBlog.ImageName = updatedBlog.ImageName;
            origBlog.Title = updatedBlog.Title;
        }


        public Blog GetBlogById(int id)
        {
            return _blogList.Find(b => b.Id == id);

        }

        public List<Blog> GetBlogList()
        {
            return _blogList;
        }

    }
}
