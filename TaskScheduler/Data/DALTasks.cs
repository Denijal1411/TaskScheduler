using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Data
{
    public class DALTasks : DAL<Task>
    {
        private static GetDatabaseEntities db = new GetDatabaseEntities();


        public List<Project> GetProjects()
        {
            return db.Projects.Where(x => x.Active == true).ToList();
        }
        public List<string> GetStatuses()
        {
            return new List<string>() { "New", "In Progress", "Finished" };
        }

        public void Add(Task t)
        {
            db.Tasks.Add(t);
            db.SaveChanges();
            Thread.Sleep(1000);
        }

        public void Delete(Task t)
        {
            var searchTask = db.Tasks.FirstOrDefault(x => x.ID == t.ID);
            db.Tasks.Remove(searchTask);
            db.SaveChanges();
        }

        public Task Get(Task t)
        {
            return db.Tasks.FirstOrDefault(x => x.ID == t.ID);
        }

        public List<Task> GetAll()
        {
            return db.Tasks.ToList();
        }
        public void Update(Task t)
        {
            var search = db.Tasks.FirstOrDefault(x => x.ID == t.ID);
            search.Progress = t.Progress;
            search.Status = t.Status;
            search.IDProject = t.IDProject;
            search.Description = t.Description;
            search.Deadline = t.Deadline;
            search.Assignee = t.Assignee;
            db.SaveChanges();
        }

        public List<Task> GetAllTaskInProject(int idProject,string additionalSearchField) // this method give me some information about searh task from Project details
        {
            List<Task> searchData = new List<Task>();
            switch (additionalSearchField)
            {
                case "numOfTask":
                    searchData=GetAll().Where(x => x.IDProject == idProject).ToList(); 
                    break;
                case "New": 
                    searchData =GetAll().Where(x => x.IDProject == idProject && x.Status.ToLower() == "new").ToList(); 
                    break;
                case "In Progress": 
                    searchData =GetAll().Where(x => x.IDProject == idProject && x.Status.ToLower() == "in progress").ToList(); 
                    break;
                case "Finished": 
                    searchData =GetAll().Where(x => x.IDProject == idProject && x.Status.ToLower() == "finished").ToList(); 
                    break;
                case "numOverdueTask": 
                    searchData =GetAll().Where(x => x.IDProject == idProject && x.Deadline < DateTime.Now).ToList(); 
                    break;
                case "numExpireTask": 
                    searchData =GetAll().Where(x => x.IDProject == idProject && x.Deadline > DateTime.Now && x.Deadline < DateTime.Now.AddDays(2)).ToList(); 
                    break;
                default:
                    searchData=null;
                    break;
            }
            return searchData;


        }
    }
}
