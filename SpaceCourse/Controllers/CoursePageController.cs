using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SpaceCourse.Models;
namespace SpaceCourse.Controllers
{
    public class CoursePageController : Controller
    {
        SpaceCourseDB db = new SpaceCourseDB();
        // GET: CoursePage
        public ActionResult Home(int id)
        {
            ViewBag.Id = id;
            var test = db.Lessons.Where(m => m.id_course == id).ToList();
            return View(test);
        }
        public PartialViewResult Header(int id)
        {
<<<<<<< HEAD
            var lession = db.Lessons.Where(m => m.id_course == id).ToList();
            return PartialView(lession);
        }
        public PartialViewResult FollowButton(int id, int user)
        {
            if(user == 0)
            {
                return PartialView();
            }
            var follower = db.Followers.Where(m => m.id_course == id && m.id_user == user).FirstOrDefault();
            Follower tmp = new Follower();
            ViewBag.Id = id;
            if (follower == null)
            {
                tmp.id_course = id;
                tmp.id_user = user;
                return PartialView(tmp);
            }
            else
            {
                return PartialView();
            }
        }
        public PartialViewResult UnfollowBox(int id, int user)
        {
            var follower = db.Followers.Where(m => m.id_course == id && m.id_user == user).FirstOrDefault();
            if(follower != null)
            {
                return PartialView(follower);
            } else
            {
                return PartialView();
            }
        }
        [HttpPost]
        public ActionResult Unfollow(int id, int user, Follower follower)
        {
            follower = db.Followers.Where(m => m.id_course == id && m.id_user == user).FirstOrDefault();
            Follower tmp = new Follower();
            tmp.id_course = follower.id_course;
            db.Followers.Remove(follower);
            db.SaveChanges();
            return RedirectToAction("Home", "CoursePage", new { id = tmp.id_course });
        }

        [HttpPost]
        public ActionResult Follow(Follower follower)
        {
            Follower tmp = follower;
            db.Configuration.ValidateOnSaveEnabled = true;
            db.Followers.Add(follower);
            db.SaveChanges();
            return RedirectToAction("Home", "CoursePage", new {id = tmp.id_course});
=======
            var test = db.Courses.Where(m => m.id_course == id).FirstOrDefault();
            return PartialView(test);
>>>>>>> 0db3f365b62ae08ba566e6bfb216e1d93c1f80a9
        }
    }
}