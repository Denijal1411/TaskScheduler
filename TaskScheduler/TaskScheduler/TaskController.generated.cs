// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments and CLS compliance
// 0108: suppress "Foo hides inherited member Foo. Use the new keyword if hiding was intended." when a controller and its abstract parent are both processed
// 0114: suppress "Foo.BarController.Baz()' hides inherited member 'Qux.BarController.Baz()'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword." when an action (with an argument) overrides an action in a parent controller
#pragma warning disable 1591, 3008, 3009, 0108, 0114
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;
namespace TaskScheduler.Controllers
{
    public partial class TaskController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public TaskController() { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected TaskController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(Task<ActionResult> taskResult)
        {
            return RedirectToAction(taskResult.Result);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(Task<ActionResult> taskResult)
        {
            return RedirectToActionPermanent(taskResult.Result);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult DeleteTask()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.DeleteTask);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult EditTask()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.EditTask);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public TaskController Actions { get { return MVC.Task; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Task";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "Task";
        [GeneratedCode("T4MVC", "2.0")]
        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string TaskHome = "TaskHome";
            public readonly string AddTask = "AddTask";
            public readonly string DeleteTask = "DeleteTask";
            public readonly string EditTask = "EditTask";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string TaskHome = "TaskHome";
            public const string AddTask = "AddTask";
            public const string DeleteTask = "DeleteTask";
            public const string EditTask = "EditTask";
        }


        static readonly ActionParamsClass_AddTask s_params_AddTask = new ActionParamsClass_AddTask();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_AddTask AddTaskParams { get { return s_params_AddTask; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_AddTask
        {
            public readonly string model = "model";
        }
        static readonly ActionParamsClass_DeleteTask s_params_DeleteTask = new ActionParamsClass_DeleteTask();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_DeleteTask DeleteTaskParams { get { return s_params_DeleteTask; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_DeleteTask
        {
            public readonly string id = "id";
        }
        static readonly ActionParamsClass_EditTask s_params_EditTask = new ActionParamsClass_EditTask();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_EditTask EditTaskParams { get { return s_params_EditTask; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_EditTask
        {
            public readonly string id = "id";
            public readonly string model = "model";
        }
        static readonly ViewsClass s_views = new ViewsClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewsClass Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
            public class _ViewNamesClass
            {
                public readonly string AddTask = "AddTask";
                public readonly string EditTask = "EditTask";
                public readonly string TaskHome = "TaskHome";
            }
            public readonly string AddTask = "~/Views/Task/AddTask.cshtml";
            public readonly string EditTask = "~/Views/Task/EditTask.cshtml";
            public readonly string TaskHome = "~/Views/Task/TaskHome.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_TaskController : TaskScheduler.Controllers.TaskController
    {
        public T4MVC_TaskController() : base(Dummy.Instance) { }

        [NonAction]
        partial void TaskHomeOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult TaskHome()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.TaskHome);
            TaskHomeOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void AddTaskOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult AddTask()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.AddTask);
            AddTaskOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void AddTaskOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, TaskScheduler.Models.TaskCreateModel model);

        [NonAction]
        public override System.Web.Mvc.ActionResult AddTask(TaskScheduler.Models.TaskCreateModel model)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.AddTask);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            AddTaskOverride(callInfo, model);
            return callInfo;
        }

        [NonAction]
        partial void DeleteTaskOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string id);

        [NonAction]
        public override System.Web.Mvc.ActionResult DeleteTask(string id)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.DeleteTask);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            DeleteTaskOverride(callInfo, id);
            return callInfo;
        }

        [NonAction]
        partial void EditTaskOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string id);

        [NonAction]
        public override System.Web.Mvc.ActionResult EditTask(string id)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.EditTask);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            EditTaskOverride(callInfo, id);
            return callInfo;
        }

        [NonAction]
        partial void EditTaskOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, TaskScheduler.Models.TaskModel model);

        [NonAction]
        public override System.Web.Mvc.ActionResult EditTask(TaskScheduler.Models.TaskModel model)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.EditTask);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            EditTaskOverride(callInfo, model);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009, 0108, 0114
