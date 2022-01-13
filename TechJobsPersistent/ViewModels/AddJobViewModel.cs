﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {

        public string Name { get; set; }
        public int SelectEmployerId { get; set; }

        public List<SelectListItem> Employers { get; set; }

        public List<Skill> Skills { get; set; }


        public AddJobViewModel()
        {

        }

        public AddJobViewModel(List<Employer> employers, List<Skill> skills)
        {

            Employers = new List<SelectListItem>();
            foreach (var employer in employers)
            {
                Employers.Add(
                    new SelectListItem
                    {
                        Value = employer.Id.ToString(),
                        Text = employer.Name
                    }
                    );
 
            }

            Skills = skills;
        }

    }
}