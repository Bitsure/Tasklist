using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseAccessLibrary
{
    public class TaskHandler
    {
        private DataAccess _db;

        public TaskHandler(DataAccess db)
        {
            this._db = db;
        }

        public List<TaskData> GetUserTasks(int UserId)
        {
            string sql = "select * from Tasks,Users where Tasks.userID=Users.userId and Tasks.userId=@UserId";
            return _db.GetData<TaskData, dynamic>(sql, new { UserId });
        }

        public void InsertTask(TaskData task)
        {
            string sql = @"insert into dbo.Tasks (userId, Topic, Description, Date, Finished)
                            values (@UserId, @Topic, @Description, @Date, @Finished)";
            _db.AddTask(sql, task);
        }

        public List<TaskData> RemoveFinishedTasks(List<TaskData> tasks)
        {
            List<TaskData> updatedTasks = new List<TaskData>();
            string sql = @"delete from dbo.Tasks where taskId=@id";
            foreach(var task in tasks)
            {
                if (task.Finished)
                {
                    _db.RemoveTask(sql, task.taskId);
                }
                else
                {
                    updatedTasks.Add(task);
                }
            }
            return updatedTasks;
        }
    }
}
