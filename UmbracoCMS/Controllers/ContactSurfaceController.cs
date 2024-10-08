﻿using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core.Cache;
using Umbraco.Cms.Core.Logging;
using Umbraco.Cms.Core.Routing;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Infrastructure.Persistence;
using Umbraco.Cms.Web.Website.Controllers;
using UmbracoCMS.Models;

namespace UmbracoCMS.Controllers
{
    public class ContactSurfaceController : SurfaceController
    {
        public ContactSurfaceController(IUmbracoContextAccessor umbracoContextAccessor, IUmbracoDatabaseFactory databaseFactory, ServiceContext services, AppCaches appCaches, IProfilingLogger profilingLogger, IPublishedUrlProvider publishedUrlProvider) : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
        {
        }

        public IActionResult HandleSubmit(ContactFormModel form)
        {
            if (!ModelState.IsValid)
            {
                ViewData["name"] = form.Name;
                ViewData["phone"] = form.Phone;
                ViewData["email"] = form.Email;
                ViewData["service"] = form.Service;

                ViewData["error_name"] = string.IsNullOrEmpty(form.Name);
                ViewData["error_email"] = string.IsNullOrEmpty(form.Email);
                ViewData["error_service"] = string.IsNullOrEmpty(form.Service);

                return CurrentUmbracoPage();
            }

            ViewData["success"] = "Form submitted successfully";
            return CurrentUmbracoPage();
        }
    }
}
