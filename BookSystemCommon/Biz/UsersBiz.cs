using System;
using System.Collections.Generic;
using System.Data;
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
                    CreatedTime = DateTime.Now,
                    Sex = source.Sex
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
                existedUser.Sex = updateSource.Sex;
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

        public string ImportUser(string filePath)
        {
            var msg = new StringBuilder();
            var data = new DataTable();

            try
            {
                data = ExcelHelpers.ImportExcelToDataTable(filePath);
            }
            catch (Exception ex)
            {
                msg.AppendLine("导入失败！");
                msg.AppendLine("1.请确认模板是否正确，或者下载最新模板");
                msg.AppendLine("2.请确认Excel中没有空的行");
                msg.AppendLine("3.请勿对行进行增删操作");

                return msg.ToString();
            }

            if (data.Rows.Count == 0)
            {
                return "无法导入，用户信息为空";
            }

            var addUserList = new List<User>();
            foreach (DataRow row in data.Rows)
            {
                //1. first to validate required property
                if (string.IsNullOrEmpty(row["姓名"].ToString())
                    || string.IsNullOrEmpty(row["电话"].ToString())
                    || string.IsNullOrEmpty(row["生日"].ToString())
                    || string.IsNullOrEmpty(row["过期时间"].ToString())
                    || string.IsNullOrEmpty(row["性别"].ToString()))
                {
                    msg.AppendLine($"必要字段缺失请检查姓名，电话，行号：{data.Rows.IndexOf(row) + 1}");
                    continue;
                }

                var birthday = Convert.ToDateTime(row["生日"]);
                var comments = row["备注"].ToString();
                var expireTime = Convert.ToDateTime(row["过期时间"]);
                var mobile = row["电话"].ToString();
                var name = row["姓名"].ToString();
                var sex = row["性别"].ToString();

                if (IsRepetitionUser(name, mobile))
                {
                    msg.AppendLine($"该用户已存在,名字：{name},电话：{mobile},行号：{data.Rows.IndexOf(row) + 1}");
                    continue;
                }

                if (expireTime < DateTime.Now)
                {
                    msg.AppendLine($"无法导入,过期时间小于当前时间，名字：{name},电话：{mobile},行号：{data.Rows.IndexOf(row) + 1}");
                    continue;
                }

                User user = new User()
                {
                    Id = Guid.NewGuid(),
                    Birthday = birthday,
                    Comments = comments,
                    CreatedTime = DateTime.Now,
                    ExpireTime = expireTime,
                    Mobile = mobile,
                    Name = name,
                    Sex = sex
                };

                addUserList.Add(user);
            }

            using (var db = Heart.CreateBookDbContext())
            {
                db.Users.AddRange(addUserList);
                db.SaveChanges();
            }

            if (string.IsNullOrEmpty(msg.ToString()))
            {
                return "用户导入成功";
            }

            return msg.ToString();
        }

        private bool IsRepetitionUser(string userName, string mobile)
        {
            using (var db = Heart.CreateBookDbContext())
            {
                return db.Users.Any(u => u.Name == userName && u.Mobile == mobile);
            }
        }

    }
}
