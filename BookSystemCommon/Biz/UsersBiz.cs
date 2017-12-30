using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSystemCommon.Models.Biz
{
    public class UsersBiz
    {

        public void CreateUser(User source)
        {
            if (source == null)
            {
                throw new Exception("创建用户为空");
            }

            using (var db = Heart.CreateBookDbContext())
            {
                var createUser = new User()
                {
                    Id = Guid.NewGuid(),
                    Birthday = source.Birthday,
                    Comments = source.Comments,
                    ExpireTime = source.ExpireTime,
                    Mobile = source.Mobile,
                    Name = source.Name,
                    CreatedTime = DateTime.Now
                };
                db.Users.Add(createUser);
                db.SaveChanges();
            }
        }

        public void UpdateUser(User updateSource)
        {
            if (updateSource == null)
            {
                throw new Exception("更新用户不能为空");
            }

            using (var db = Heart.CreateBookDbContext())
            {
                var existedUser = db.Users.FirstOrDefault(u => u.Id == updateSource.Id);
                if (existedUser == null)
                {
                    throw new Exception("未找到可更新的用户");
                }
                db.Users.Attach(existedUser);
                existedUser.Mobile = updateSource.Mobile;
                // existedUser.Name = updateSource.Name; // 姓名不可以更改
                existedUser.ExpireTime = updateSource.ExpireTime;
                existedUser.Comments = updateSource.Comments;
                existedUser.Birthday = updateSource.Birthday;
                db.SaveChanges();
            }
        }

        public User GetUserById(Guid userId)
        {
            using (var db = Heart.CreateBookDbContext())
            {
                return db.Users.FirstOrDefault(u => u.Id == userId);
            }
        }
        public void DeleteUser(List<Guid> userIds)
        {
            if (!userIds.Any())
            {
                return;
            }

            using (var db = Heart.CreateBookDbContext())
            {
                var deleteUsers = new List<User>();

                foreach (var id in userIds)
                {
                    var user = db.Users.FirstOrDefault(u => u.Id == id);
                    if (user == null)
                    {
                        throw new Exception($"无法删除当前用户，用户id:{id}");
                    }
                    deleteUsers.Add(user);
                }

                db.Users.RemoveRange(deleteUsers);
                db.SaveChanges();
            }
        }

        public List<User> GetAllUsers()
        {
            using (var db = Heart.CreateBookDbContext())
            {
                return db.Users.ToList();
            }
        }
    }
}
