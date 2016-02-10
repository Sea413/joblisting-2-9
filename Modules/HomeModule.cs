using Nancy;
using Openings.Objects;
using System.Collections.Generic;

namespace Openings
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["add_new_job.cshtml"];
      Get["/view_all_jobs"] = _ => {
        List<object> allJobs = Job.GetAll();
        return View["view_all_jobs.cshtml", allJobs];
      };
      Post["/job_added"] = _ => {

        Contact newContact = new Contact (Request.Form["contactname"],Request.Form["contactphone"],Request.Form["contactemail"]);
        Job newJob = new Job (Request.Form["title"], Request.Form["description"],Request.Form["salary"], newContact);

        newJob.Save();
        return View["job_added.cshtml", newJob];
      };
      Post["/jobs_cleared"] = _ => {
        Job.ClearAll();
        return View["jobs_cleared.cshtml"];
      };
    }
  }
}
