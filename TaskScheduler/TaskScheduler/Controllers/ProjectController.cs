using Data;
using TaskScheduler.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TaskScheduler.Controllers
{
    [Authorize(Roles = "Administrator, Project Manager")]
    public partial class ProjectController : Controller
    {
        DALProject dal=new DALProject();
        DALTasks dalTask=new DALTasks(); 
        public virtual ActionResult ProjectHome()
        {
            List<ProjectModel> model = new List<ProjectModel>();
            foreach (var item in dal.GetAll())
            {
                model.Add(new ProjectModel()
                {
                     Assignee=item.Assignee,
                     Name=item.ProjectName,
                     ProjectCode=item.ProjectCode,
                     Tasks=item.Tasks,
                     User=item.User
                });
            }
            return View(model);
        }
        public virtual ActionResult AddProject()
        { 
            ProjectModel allManagers = new ProjectModel();
            allManagers.Users = dal.GetManagers();
            allManagers.Assignee = User.Identity.Name;
            return View(allManagers);
        } 
        [HttpPost]
        public virtual ActionResult AddProject(ProjectModel model)
        {
            if (model.Name.Trim() == "") ModelState.AddModelError("Name", "Name is required.");
            if (ModelState.IsValid) {
                dal.Add(new Project(){ProjectName = model.Name.Trim(),Assignee=model.Assignee,Active=true});
                return RedirectToAction("ProjectHome", "Project");
            } 
            return View();
              
        }
        [Authorize(Roles ="Administrator")]
        public virtual ActionResult DeleteProject(string projectCode)
        {
            dal.Delete(new Project() { ProjectCode = Convert.ToInt32(projectCode)});
            return RedirectToAction("ProjectHome", "Project");
        }
        [Authorize(Roles ="Administrator")]
        public virtual ActionResult EditProject(string projectCode)
        {
            try
            {
                var project = dal.Get(new Project() { ProjectCode=Convert.ToInt32(projectCode)});
                if (project == null) { throw new ArgumentException("project is null"); }
                ProjectModel allManagers = new ProjectModel();
                allManagers.Users = dal.GetManagers();

                return View(new ProjectModel(){
                    Name=project.ProjectName,
                    ProjectCode=project.ProjectCode,
                    Assignee=project.Assignee ,
                    Users= allManagers.Users
                });
            }
            catch (Exception e)
            {
                return RedirectToAction("ProjectHome", "Project");
            }

        }
        [HttpPost]
        public virtual ActionResult EditProject(ProjectModel model)
        {
            if (ModelState.IsValid)
            {
                dal.Update(new Project()
                {
                    ProjectCode=model.ProjectCode,
                    ProjectName=model.Name.Trim(),
                    Assignee=model.Assignee,
                    Active=true
                });
                return RedirectToAction("ProjectHome", "Project");
            } 
            return View();

        }
        [Authorize(Roles ="Project Manager")]
        public virtual ActionResult popUpPartial(int id) {

            try
            {
                TempData["ProjectName"] = dal.Get(new Project() { ProjectCode = id }).ProjectName;
                TempData["AvgProgress"] = getProgresStatistics(id).ToString("F");
                TempData["numOfTaskPerStatus"] = getTasksPerStatus(id); // must use this method because I want dictionary type
                TempData["numOfTask"] = dalTask.GetAllTaskInProject(id, "numOfTask").Count();
                TempData["numOverdueTask"] = dalTask.GetAllTaskInProject(id, "numOverdueTask").Count();
                TempData["numExpireTask"] = dalTask.GetAllTaskInProject(id, "numExpireTask").Count();
                return PartialView(id);
            }
            catch (Exception)
            {

                return RedirectToAction("ProjectHome", "Project");
            }
        }


        #region Statistics
        private double getProgresStatistics(int id) {
            try
            {
                var allTask = dalTask.GetAll().Where(x => x.IDProject == id);
                var avg = allTask.Sum(x => x.Progress) * 1.0 / allTask.Count();
                return allTask.Count()==0 ? 0.0 : (double)avg;
            }
            catch (Exception)
            {

                return 0.0;
            }
           
        }
        private Dictionary<string,int> getTasksPerStatus(int id)
        {
            Dictionary<string, int> data = new Dictionary<string, int>();
            var newStatus=dalTask.GetAll().Where(x => x.IDProject == id && x.Status.ToLower() == "new").Count();
            var progressStatus=dalTask.GetAll().Where(x => x.IDProject == id && x.Status.ToLower() == "in progress").Count();
            var finishedStatus=dalTask.GetAll().Where(x => x.IDProject == id && x.Status.ToLower() == "finished").Count();

            data.Add("New", newStatus);
            data.Add("In Progress", progressStatus);
            data.Add("Finished", finishedStatus);

            return data;
        } 
        #endregion
    }
}