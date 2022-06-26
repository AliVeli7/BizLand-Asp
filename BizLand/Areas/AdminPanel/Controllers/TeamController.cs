using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BizLand.DAL;
using BizLand.Helpers;
using BizLand.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BizLand.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class TeamController : Controller
    {
        private AppDbContext _context { get; }
        public IWebHostEnvironment _env { get; }
        public IEnumerable<TeamMember> TeamMembers;
        public TeamController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
            TeamMembers = _context.TeamMembers.Where(p => !p.IsDeleted).ToList();
            
        }
        public IActionResult Index()
        {
            ViewBag.Icons = _context.SocialMedias.ToList();
           
            return View(TeamMembers);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TeamMember member)
        {
            if (!ModelState.IsValid) return View();

            TeamMember Newmember = new TeamMember
            {
                FaceBookURl = member.FaceBookURl,
                InstagramURl = member.InstagramURl,
                LinkedinURl = member.LinkedinURl,
                TwitterURl = member.TwitterURl,
                JobName = member.JobName,
                Name = member.Name,
                SurName = member.SurName
               
            };
            string Url = await member.Photo.SaveFileAsync(_env.WebRootPath, "img");
            Newmember.URl = Url;
            await _context.TeamMembers.AddAsync(Newmember);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return BadRequest();
            TeamMember memberDb = _context.TeamMembers.Where(c => !c.IsDeleted).FirstOrDefault(c => c.Id == id);
            if (memberDb == null)
                return NotFound();
            //_context.TeamMembers.Remove(memberDb);
            memberDb.IsDeleted = true;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Update(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var member = _context.TeamMembers.Find(id);
            if (member == null)
            {
                return NotFound();
            }
            return View(member);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id,TeamMember member)
        {
            if (id == null)
            {

            }
            var memberDb = _context.TeamMembers.Find(id);
            if (memberDb == null)
            {
                return NotFound();
            }
            if (!ModelState.IsValid)
            {
                return View();
            }

            TeamMember Newmember = new TeamMember
            {
                FaceBookURl = member.FaceBookURl,
                InstagramURl = member.InstagramURl,
                LinkedinURl = member.LinkedinURl,
                TwitterURl = member.TwitterURl,
                JobName = member.JobName,
                Name = member.Name,
                SurName = member.SurName

            };
            string Url = await member.Photo.SaveFileAsync(_env.WebRootPath, "img");
            Newmember.URl = Url;
            TeamMember MemberDb = _context.TeamMembers.Where(c => !c.IsDeleted).FirstOrDefault(c => c.Id == id);
            memberDb.IsDeleted = true;
            await _context.TeamMembers.AddAsync(Newmember);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
