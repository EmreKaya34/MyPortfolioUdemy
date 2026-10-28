using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;
using MyPortfolioUdemy.DAL.Entities;

namespace MyPortfolioUdemy.ViewComponents
{
    public class _SkillComponentPartial:ViewComponent
    {
        MyPortfolioContext _portfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = _portfolioContext.Skills.ToList();
            return View(values);
        }
    }
}
