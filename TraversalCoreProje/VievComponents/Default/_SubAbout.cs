﻿using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.VievComponents.Default
{
    public class _SubAbout:ViewComponent
    {
        SubAboutManager subAboutManager=new SubAboutManager(new EfSubAboutDal());
        public IViewComponentResult Invoke()
        {
            var values = subAboutManager.TGetList();
            return View(values); 
        }
    }
}
