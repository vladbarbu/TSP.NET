﻿using System.Linq;
using System.Data.Entity;
using System.Collections.Generic;

namespace WCF_si_EF
{
    public partial class Post
    {
        public bool AddPost()
        {
            using (PostCommentContainer ctx = new PostCommentContainer())
            {
                bool bResult = false;
                if (this.PostId == 0)
                {
                    var it = ctx.Entry<Post>(this).State = EntityState.Added;
                    ctx.SaveChanges();
                    bResult = true;
                }
                return bResult;
            }
        }
        public Post UpdatePost(Post newPost)
        {
            using (PostCommentContainer ctx = new PostCommentContainer())
            {
                Post oldPost = ctx.Posts.Find(newPost.PostId);
                if (oldPost == null) // nu exista in bd
                {
                    return null;
                }
                oldPost.Description = newPost.Description;
                oldPost.Domain = newPost.Domain;
                oldPost.Date = newPost.Date;
                ctx.SaveChanges();
                return oldPost;
            }
        }
        public int DeletePost(int id)
        {
            using (PostCommentContainer ctx = new PostCommentContainer())
            {
                return ctx.Database.ExecuteSqlCommand("Delete From Post where postid =@p0", id);
            }
        }
        public Post GetPostById(int id)
        {
            using (PostCommentContainer ctx = new PostCommentContainer())
            {
                var items = from p in ctx.Posts where (p.PostId == id) select p;
                if (items != null)
                    return items.Include(c => c.Comments).SingleOrDefault();
                return null; // trebuie verificat in apelant
            }
        }
        public List<Post> GetAllPosts()
        {
            using (PostCommentContainer ctx = new PostCommentContainer())
            {
                return ctx.Posts.Include("Comments").ToList<Post>();
                // Obligatoriu de verificat in apelant rezultatul primit.
            }
        }
    }
}
