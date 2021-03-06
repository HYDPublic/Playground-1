﻿using Playground.core.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Playground.core.Services
{
    public class SeedService
    {
        private readonly PlaygroundContext m_context;

        public SeedService( PlaygroundContext context )
        {
            m_context = context;
        }
        
        public void Seed() 
        {
            m_context.Database.Migrate();

            var company = m_context.Companies.FirstOrDefault(p => p.Name == "Hallo");

            if (company == null)
            {
                company = new Company()
                {
                    Name = "Hallo"
                };

                m_context.Companies.Add(company);
            }

            if (!m_context.Sites.Any(p => p.Name == "Hallo"))
            {
                m_context.Sites.Add(new Site()
                {
                    Name = "Hallo",
                    Company = company,
                });
            }

            if (!m_context.Sites.Any(p => p.Name == "Bye"))
            {
                m_context.Sites.Add(new Site()
                {
                    Name = "Bye",
                    Company = company,
                });
            }

            var missing = 1000 - m_context.Companies.Count();

            for (int i = 0; i < missing; i++)
            {

                m_context.Companies.Add(new Company()
                {
                    Name = $"C{i}"
                });
            }
            
            m_context.SaveChanges();

            //foreach (var companyx in m_context.Companies)
            //{
            //    var missing = 1000 - company.Sites.Count;

            //    for (int i = 0; i < missing; i++)
            //    {
            //        m_context.Sites.Add(new Site()
            //        {
            //            Name = $"S{i}",
            //            Company = companyx
            //        });
            //    }
            //}

            //m_context.SaveChanges();
        }
    }
}
